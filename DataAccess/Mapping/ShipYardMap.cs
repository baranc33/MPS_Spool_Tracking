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

            builder.Property(r => r.IsDelete).IsRequired(true);
            builder.Property(r => r.IsWork).IsRequired(true);
            builder.Property(r => r.ReallyDeleted).IsRequired(true);


            builder.Property(r => r.ModifiedUserName).IsRequired(true);
            builder.Property(r => r.ModifiedTime).IsRequired(true);
            builder.Property(r => r.CreateUser).IsRequired(true);
            builder.Property(r => r.CreateTime).IsRequired(true);


            builder.Property(r => r.ShipYardName).IsRequired(true);
            builder.Property(r => r.ShipYardName).HasMaxLength(50);
        }
    }
}




