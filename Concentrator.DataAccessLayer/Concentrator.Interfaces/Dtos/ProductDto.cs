using System;
using System.Collections.Generic;

using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.SharedObjects.Dtos
{
  public partial class ProductDto : BaseDto, IProduct
  {
    public int ProductID { get; set; }
    public string VendorItemNumber { get; set; }
    public int BrandID { get; set; }
    public int SourceVendorID { get; set; }
    public int CreatedBy { get; set; }
    public System.DateTime CreationTime { get; set; }
    public Nullable<System.DateTime> LastModificationTime { get; set; }
    public Nullable<int> LastModifiedBy { get; set; }
    public bool IsConfigurable { get; set; }
    public Nullable<bool> IsNonAssortmentItem { get; set; }
    public Nullable<int> ParentProductID { get; set; }
    public bool Visible { get; set; }
    public bool IsBlocked { get; set; }
    public virtual IBrand Brand { get; set; }
    
  }
}
