using System.Collections.Generic;
using Concentrator.Interfaces;
using Concentrator.SharedObjects.Dto;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.Processes.SendersReceivers.Custom
{
  /// <summary>
  /// 
  /// </summary>
  public class PFAProductSender : ProductSender
  {
    public PFAProductSender(ICallerContext context, IProductService productService)
      : base(context, productService)
    {
    }

    public override void Process()
    {
      foreach (var product in LoadProducts())
      {
        BusinessService.SendToBus(Context, product);
      }
    }

    private IEnumerable<ProductDto> LoadProducts()
    {
      throw new System.NotImplementedException();
    }
  }
}
