using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;

namespace DataAccess.Mapping
{
    public class ShipYardMap : IEntityTypeConfiguration<ShipYard>
    {
        public void Configure(EntityTypeBuilder<ShipYard> builder)
        {

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.IsDeleted).IsRequired(true);
            builder.Property(r => r.IsWork).IsRequired(true);
            builder.Property(r => r.ReallyDeleted).IsRequired(true);
            builder.Property(r => r.ModifiedUserName).HasMaxLength(50);
            builder.Property(r => r.ModifiedUserName).IsRequired(true);
            builder.Property(r => r.ModifiedTime).IsRequired(true);
            builder.Property(r => r.CreateDate).IsRequired(true);
            builder.Property(r => r.CreateDate).HasColumnType("date");


            builder.Property(r => r.ShipYardName).IsRequired(true);
            builder.Property(r => r.ShipYardName).HasMaxLength(100);

            builder.Property(r => r.ShipYardManagerName).IsRequired(true);
            builder.Property(r => r.ShipYardManagerName).HasMaxLength(50);

            builder.Property(r => r.ShipYardActiveProject).IsRequired(true);
        }
    }
}




