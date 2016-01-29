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

    public List<BrandDto> GetItems(int[] ids)
    {
      return ConcentratorDataContext.Brands.Where(p => ids == null || ids.Contains(p.BrandID)).Select(p => Mapper.Map<BrandDto>(p)).ToList();
    }

    public int Insert(BrandDto brand)
    {
      var newbrand = Mapper.Map<Brand>(brand);

      ConcentratorDataContext.Brands.Attach(newbrand);
      ConcentratorDataContext.SaveChanges();

      return brand.BrandID;
    }

    public bool Update(BrandDto brand)
    {
      var orgbrand = ConcentratorDataContext.Brands.FirstOrDefault(p => brand.BrandID == p.BrandID);

      Mapper.Map(brand, orgbrand);
      ConcentratorDataContext.SaveChanges();

      return ConcentratorDataContext.SaveChanges() > 0;
    }

    public bool Delete(BrandDto brand)
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