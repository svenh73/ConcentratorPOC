using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerID);

            // Properties
            this.Property(t => t.CustomerTelephone)
                .HasMaxLength(50);

            this.Property(t => t.CustomerEmail)
                .HasMaxLength(100);

            this.Property(t => t.City)
                .HasMaxLength(100);

            this.Property(t => t.Country)
                .HasMaxLength(100);

            this.Property(t => t.PostCode)
                .HasMaxLength(50);

            this.Property(t => t.EANIdentifier)
                .HasMaxLength(50);

            this.Property(t => t.HouseNumber)
                .HasMaxLength(20);

            this.Property(t => t.CoCNumber)
                .HasMaxLength(50);

            this.Property(t => t.TaxID)
                .HasMaxLength(50);

            this.Property(t => t.CompanyName)
                .HasMaxLength(150);

            this.Property(t => t.ServicePointCode)
                .HasMaxLength(25);

            this.Property(t => t.ServicePointID)
                .HasMaxLength(25);

            this.Property(t => t.ServicePointName)
                .HasMaxLength(250);

            this.Property(t => t.Street)
                .HasMaxLength(300);

            this.Property(t => t.HouseNumberExt)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Customer");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.CustomerTelephone).HasColumnName("CustomerTelephone");
            this.Property(t => t.CustomerEmail).HasColumnName("CustomerEmail");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.PostCode).HasColumnName("PostCode");
            this.Property(t => t.CustomerAddressLine1).HasColumnName("CustomerAddressLine1");
            this.Property(t => t.CustomerAddressLine2).HasColumnName("CustomerAddressLine2");
            this.Property(t => t.CustomerAddressLine3).HasColumnName("CustomerAddressLine3");
            this.Property(t => t.EANIdentifier).HasColumnName("EANIdentifier");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.HouseNumber).HasColumnName("HouseNumber");
            this.Property(t => t.CoCNumber).HasColumnName("CoCNumber");
            this.Property(t => t.TaxID).HasColumnName("TaxID");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.ServicePointCode).HasColumnName("ServicePointCode");
            this.Property(t => t.ServicePointID).HasColumnName("ServicePointID");
            this.Property(t => t.ServicePointName).HasColumnName("ServicePointName");
            this.Property(t => t.Street).HasColumnName("Street");
            this.Property(t => t.HouseNumberExt).HasColumnName("HouseNumberExt");
        }
    }
}
