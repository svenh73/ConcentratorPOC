using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Concentrator.Entities;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.DataAccessServiceLayer
{
  public class BrandStoreService : BaseStoreService<BrandDto>, IBrandStoreService
  {
    public int[] GetIds()
    {
      return DataContext.Brands.Where(p => p.Name != null).Select(p => p.Id).ToArray();
    }

    public List<BrandDto> GetItems(int[] ids)
    {
      return DataContext.Brands.Where(p => ids == null || ids.Contains(p.Id)).Select(p => Mapper.Map<BrandDto>(p)).ToList();
    }

    public int Insert(BrandDto brand)
    {
      var newbrand = Mapper.Map<Brand>(brand);

      DataContext.Brands.Attach(newbrand);
      DataContext.SaveChanges();

      return brand.BrandID;
    }

    public bool Update(BrandDto brand)
    {
      var orgbrand = DataContext.Brands.FirstOrDefault(p => brand.BrandID == p.Id);

      Mapper.Map(brand, orgbrand);
      DataContext.SaveChanges();

      return DataContext.SaveChanges() > 0;
    }

    public bool Delete(BrandDto brand)
    {
      var orgbrand = DataContext.Brands.FirstOrDefault(p => p.Id == brand.BrandID);
      if (orgbrand != null)
      {
        DataContext.Brands.Remove(orgbrand);
        return DataContext.SaveChanges() > 0;
      }
      return false;
    }
  }
}