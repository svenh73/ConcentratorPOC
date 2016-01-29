using System;
using Concentrator.Entities;
using Concentrator.SharedObjects.Dto;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;
using Microsoft.Practices.ServiceLocation;

namespace Concentrator.BusinessLayer
{
  public class ProductBusinessService : BaseBusinessService<IProductStoreService, IProductBusService>, IProductService
  {
    public ProductBusinessService(ISettingService settingService, ILogService logService)
      : base( settingService, logService)
    {

    }

    public void InsertProduct(ICallerContext context, ProductDto product)
    {
      try
      {
        StoreService.Insert(product);

        LogService.LogInformation("");
      }
      catch (Exception ex)
      {
        LogService.LogError(ex.Message);
        throw;
      }
    }

    public ProductDto GetProduct(ICallerContext context, int id)
    {
      var storeservice = ServiceLocator.Current.GetInstance<IProductStoreService>();
      var products = storeservice.GetItems(new[] {id});
      return products[0];
    }

    public void UpdateProduct(ICallerContext context, ProductDto product)
    {
      var storeservice = ServiceLocator.Current.GetInstance<IProductStoreService>();
      storeservice.Update(product);

      LogService.LogInformation("");
    }

    public void DeleteProduct(ICallerContext context, int productid)
    {
      var storeservice = ServiceLocator.Current.GetInstance<IProductStoreService>();
      storeservice.Delete(new ProductDto {ProductID = productid});
    }

    public void SendToBus(ICallerContext context, ProductDto product)
    {
      var buservice = ServiceLocator.Current.GetInstance<IProductBusService>();
      buservice.Send(context,product);
    }

    public ProductDto ReceiveFromBus(ICallerContext context)
    {
      var buservice = ServiceLocator.Current.GetInstance<IProductBusService>();
      var envelop = buservice.Receive(context,FuncValidate);
      return envelop.Object;
    }

    public bool FuncValidate(MessageEnvelopDto<ProductDto> messageEnvelop)
    {
      throw new NotImplementedException();
    }

    public Product MapDtoToEntity(ProductDto productDto)
    {
      return AutoMapper.Mapper.Map<Product>(productDto);
    }

    public ProductDto MapEntityToDto(Product product)
    {
      return AutoMapper.Mapper.Map<ProductDto>(product);
    }
  }
}
