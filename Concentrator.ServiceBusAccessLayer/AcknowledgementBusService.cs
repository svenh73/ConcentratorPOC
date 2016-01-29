
using Concentrator.SharedObjects.Dtos;

namespace Concentrator.ServiceBusAccessLayer
{
  public class AcknowledgementBusService : BaseBusService<Acknowledgement>
  {
    public AcknowledgementBusService(string connectstring, string path) : base(connectstring, path)
    {
    }
  }
}
