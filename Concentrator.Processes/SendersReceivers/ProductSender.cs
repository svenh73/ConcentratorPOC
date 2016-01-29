using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.Processes.SendersReceivers
{
  public class ProductSender : BaseSenderReceiver<IProductService>
  {
    public ProductSender(ICallerContext context, IProductService service)
      : base(context, service)
    {
    }

    public override void Process()
    {
      BusinessService.SendToBus(Context, new ProductDto());
    }

  }
}
