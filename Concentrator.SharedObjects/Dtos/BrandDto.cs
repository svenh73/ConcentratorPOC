using System;
using System.Collections.Generic;
using Concentrator.Entities.Enums;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.SharedObjects.Dtos
{

  public partial class BrandDto : BaseDto, IBrand
  {
        public BrandDto()
        {
           this.Products = new List<ProductDto>();
        }

        public int BrandID { get; set; }
        public string Name { get; set; }

        public string Test { get; set; }
        public bool Test2 { get; set; }
        public string Test3 { get; set; }

        public BrandType Type { get; set; }
        public int? ParentBrandID { get; set; }
        public string Description { get; set; }


        public ICollection<ProductDto> Products { get; set; }
    }
}
