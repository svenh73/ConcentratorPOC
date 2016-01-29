using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concentrator.SharedObjects.Dto;
using Concentrator.SharedObjects.Dtos;

namespace Concentrator.SharedObjects.Interfaces
{
  public interface ISendReceive<T> where T : BaseDto
  {
    void Send(ICallerContext context, T obj);
    MessageEnvelopDto<T> Receive(ICallerContext context, Func<MessageEnvelopDto<T>, bool> funcValidate);
  }
}
