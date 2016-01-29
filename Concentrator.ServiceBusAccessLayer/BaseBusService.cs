using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concentrator.Core;
using Concentrator.Interfaces.Exceptions;
using Concentrator.Interfaces.Interfaces;
using Concentrator.SharedObjects;
using Microsoft.ServiceBus.Messaging;

namespace Concentrator.ServiceBusAccessLayer
{

  public class BaseBusService<T>
  {

      public string _connectstring { get; set; }
      public string _path { get; set; }

      protected BaseBusService(string connectstring, string path)
      {
        _connectstring = connectstring;
        _path = path;
      }

      public void Send(ICallerContext context, T obj)
      {
        var client = QueueClient.CreateFromConnectionString(_connectstring, _path, ReceiveMode.PeekLock);

        var message = new MessageEnvelop<T>(obj, context.UserId);

        var brokermessage = new BrokeredMessage(message);
        brokermessage.Properties["MessageType"] = message.Object.GetType().AssemblyQualifiedName;
        
        if (context.ConnectorId.HasValue)
        {
          brokermessage.Properties["ConnectorId"] = context.ConnectorId.Value;
        }
        if (context.VendorId.HasValue)
        {
          brokermessage.Properties["VendorId"] = context.VendorId.Value;
        }

        try
        {
          client.Send(brokermessage);
          brokermessage.Complete();
        }
        catch (Exception ex)
        {
          if (brokermessage.DeliveryCount > 3)
          {
            brokermessage.DeadLetter(ErrorMessages.MessageQueue_SendMessageException, ex.Message);
          }
          throw;
        }
      }

      public List<MessageEnvelop<T>> ReceiveDeadletters()
      {
        return new List<MessageEnvelop<T>>();
      }

      public MessageEnvelop<T> Receive(ICallerContext context, Func<MessageEnvelop<T>, bool> funcValidate)
      {
        var client = QueueClient.CreateFromConnectionString(_connectstring, _path, ReceiveMode.PeekLock);

        BrokeredMessage message = null;
        try
        {
          message = client.Receive();
          var metadata = message.GetBody<MessageEnvelop<T>>();

          if (funcValidate(metadata))
          {
            message.Complete();
          }
          return metadata;
        }
        catch (ValidationException ex)
        {
          message.DeadLetter(ErrorMessages.MessageQueue_ValidationErrorsHeader, ex.Message);
          throw;
        }
        catch (Exception ex)
        {
          if (message != null)
          {
            message.DeadLetter(ErrorMessages.MessageQueue_UnknownReceiveError, ex.Message);
          }
          throw;
        }
      }
    }
}
