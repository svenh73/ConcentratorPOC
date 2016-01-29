using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class MagentoPageLayoutMap : EntityTypeConfiguration<MagentoPageLayout>
    {
        public MagentoPageLayoutMap()
        {
            // Primary Key
            this.HasKey(t => t.LayoutID);

            // Properties
            this.Property(t => t.LayoutCode)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("MagentoPageLayout");
            this.Property(t => t.LayoutID).HasColumnName("LayoutID");
            this.Property(t => t.LayoutName).HasColumnName("LayoutName");
            this.Property(t => t.LayoutCode).HasColumnName("LayoutCode");
        }
    }
}
