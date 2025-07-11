using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class ProjectMap : IEntityTypeConfiguration<Project> 
    { 
        public void Configure(EntityTypeBuilder<Project> builder)
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

             
            builder.Property(r => r.ProjectStartDate).IsRequired(true);
            builder.Property(r => r.ProjectStartDate).HasColumnType("date");
            builder.Property(r => r.ProjectFinishDate).HasColumnType("date");


            builder.Property(r => r.ShipYardId).IsRequired(true);
            builder.Property(r => r.ProjectName).HasMaxLength(100);
            builder.Property(r => r.ProjectName).IsRequired(true);


            builder.Property(r => r.ProjectManagerId).HasMaxLength(50);
            builder.Property(r => r.ProjectManagerId).IsRequired(true);
            builder.HasOne<ShipYard>(a => a.ShipYard).WithMany(u => u.Projects).HasForeignKey(a => a.ShipYardId);
        }
    }
}




