using System.Collections.Generic;
using Concentrator.Entities.Enums;
using Concentrator.SharedObjects.Dtos;

namespace Concentrator.SharedObjects.Interfaces
{
  public interface IBrand
  {
    int BrandID { get; set; }
    string Name { get; set; }

    string Test { get; set; }
    string Test3 { get; set; }

    BrandType Type { get; set; }
    int? ParentBrandID { get; set; }
    string Description { get; set; }
    bool Test2 { get; set; }
    
    ICollection<ProductDto> Products { get; set; }

  }
}
