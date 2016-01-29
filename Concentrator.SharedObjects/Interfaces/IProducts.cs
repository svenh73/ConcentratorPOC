using System;
using Concentrator.SharedObjects;

namespace Concentrator.SharedObjects.Interfaces
{
  public interface IProduct
  {
    int ProductID { get; set; }
    string VendorItemNumber { get; set; }
    int BrandID { get; set; }
    int SourceVendorID { get; set; }
    int CreatedBy { get; set; }
    DateTime CreationTime { get; set; }
    DateTime? LastModificationTime { get; set; }
    int? LastModifiedBy { get; set; }
    bool IsConfigurable { get; set; }
    bool? IsNonAssortmentItem { get; set; }
    int? ParentProductID { get; set; }
    bool Visible { get; set; }
    bool IsBlocked { get; set; }
    IBrand Brand { get; set; }
    
  }
}
