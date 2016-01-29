using System.ComponentModel.DataAnnotations.Schema;
using Concentrator.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Concentrator.DataLayer.Models.Mapping
{
    public class UserLanguageMap : EntityTypeConfiguration<UserLanguage>
    {
        public UserLanguageMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UserID, t.LanguageID });

            // Properties
            this.Property(t => t.UserID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LanguageID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("UserLanguage");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.LanguageID).HasColumnName("LanguageID");
        }
    }
}
