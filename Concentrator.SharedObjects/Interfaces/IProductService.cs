using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concentrator.Entities;
using Concentrator.SharedObjects;
using Concentrator.SharedObjects.Dtos;

namespace Concentrator.SharedObjects.Interfaces
{
  public interface IProductService : IBaseBusinessService
  {
    ProductDto GetProduct(ICallerContext context, int id);
    void InsertProduct(ICallerContext context, ProductDto product);
    void UpdateProduct(ICallerContext context, ProductDto product);
    void DeleteProduct(ICallerContext context, int productid);
    void SendToBus(ICallerContext context, ProductDto product);
    ProductDto ReceiveFromBus(ICallerContext context);
  }
}
