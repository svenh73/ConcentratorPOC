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
      return ConcentratorDataContext.Products.Where(p => !p.IsBlocked && p.Visible).Select(p => p.ProductID).ToArray();
    }

    public virtual List<ProductDto> GetItems(int[] ids)
    {
      return
        ConcentratorDataContext.Products.Where(p => ids == null || ids.Contains(p.ProductID))
          .Select(p => Mapper.Map<ProductDto>(p))
          .ToList();
    }

    public virtual int Insert(ProductDto item)
    {
      var product = new Product();
      Mapper.Map(item, product);
      ConcentratorDataContext.Products.Attach(product);
      ConcentratorDataContext.SaveChanges();

      return product.ProductID;
    }

    public virtual bool Update(ProductDto item)
    {
      var product = ConcentratorDataContext.Products.FirstOrDefault(p => item.ProductID == p.ProductID);

      Mapper.Map(item, product);
      ConcentratorDataContext.SaveChanges();

      return ConcentratorDataContext.SaveChanges() > 0;
    }

    public virtual bool Delete(ProductDto item)
    {
      var product = ConcentratorDataContext.Products.FirstOrDefault(p => p.ProductID == item.ProductID);
      if (product != null)
      {
        ConcentratorDataContext.Products.Remove(product);
        return ConcentratorDataContext.SaveChanges() > 0;
      }
      return false;
    }
  }
}