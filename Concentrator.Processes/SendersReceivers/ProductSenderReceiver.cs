using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.Processes.SendersReceivers
{
  public class ProductReceiver : BaseSenderReceiver<IProductService>
  {
    public ProductReceiver(ICallerContext context, IProductService service)
      : base(context, service)
    {
    }

    public override void Process()
    {
      var product = BusinessService.ReceiveFromBus(Context);

      while (product != null)
      {
        BusinessService.InsertProduct(Context, product);

        product = BusinessService.ReceiveFromBus(Context);
      }
    }
  }
}
