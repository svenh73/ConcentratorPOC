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
      return ConcentratorDataContext.Brands.Where(p => p.Name != null).Select(p => p.BrandID).ToArray();
    }

    public List<Brand> GetItems(int[] ids)
    {
      return ConcentratorDataContext.Brands.Where(p => ids == null || ids.Contains(p.BrandID)).Select(p => p).ToList();
    }

    public int Insert(Brand brand)
    {
      ConcentratorDataContext.Brands.Attach(brand);
      ConcentratorDataContext.SaveChanges();

      return brand.BrandID;
    }

    public bool Update(Brand brand)
    {
      var orgbrand = ConcentratorDataContext.Brands.FirstOrDefault(p => brand.BrandID == p.BrandID);

      Mapper.Map(brand, orgbrand);
      ConcentratorDataContext.SaveChanges();

      return ConcentratorDataContext.SaveChanges() > 0;
    }

    public bool Delete(Brand brand)
    {
      var orgbrand = ConcentratorDataContext.Brands.FirstOrDefault(p => p.BrandID == brand.BrandID);
      if (orgbrand != null)
      {
        ConcentratorDataContext.Brands.Remove(orgbrand);
        return ConcentratorDataContext.SaveChanges() > 0;
      }
      return false;
    }
  }
}