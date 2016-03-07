using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Concentrator.Entities;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.DataAccessServiceLayer
{
  public class ProductStoreService : BaseStoreService<ProductDto>, IProductStoreService
  {
    public virtual int[] GetIds()
    {
      return DataContext.Products.Select(p => p.Id).ToArray();
    }

    public virtual List<ProductDto> GetItems(int[] ids)
    {
      return
        DataContext.Products.Where(p => ids == null || ids.Contains(p.Id))
          .Select(p => Mapper.Map<ProductDto>(p))
          .ToList();
    }

    public virtual int Insert(ProductDto item)
    {
      var product = new Product();
      Mapper.Map(item, product);
      DataContext.Products.Attach(product);
      DataContext.SaveChanges();

      return product.Id;
    }

    public virtual bool Update(ProductDto item)
    {
      var product = DataContext.Products.FirstOrDefault(p => item.ProductID == p.Id);

      Mapper.Map(item, product);
      DataContext.SaveChanges();

      return DataContext.SaveChanges() > 0;
    }

    public virtual bool Delete(ProductDto item)
    {
      var product = DataContext.Products.FirstOrDefault(p => p.Id == item.ProductID);
      if (product != null)
      {
        DataContext.Products.Remove(product);
        return DataContext.SaveChanges() > 0;
      }
      return false;
    }
  }
}