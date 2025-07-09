using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.Entities.DataBaseTable.UsersData;

namespace DataAccess.Mapping
{
    public class ProjectMap : IEntityTypeConfiguration<Project> 
    { 
        public void Configure(EntityTypeBuilder<Project> builder)
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





            builder.Property(r => r.ShipYardId).IsRequired(true);
            builder.Property(r => r.ProjectStartTime).IsRequired(true);

            builder.Property(r => r.ProjectName).HasMaxLength(100);
            builder.Property(r => r.ProjectName).IsRequired(true);




            builder.Property(r => r.ProjectManagerId).HasMaxLength(50);
            builder.Property(r => r.ProjectManagerId).IsRequired(true);

            builder.HasOne<ShipYard>(a => a.ShipYard).WithMany(u => u.Projects).HasForeignKey(a => a.ShipYardId);
        }
    }
}




