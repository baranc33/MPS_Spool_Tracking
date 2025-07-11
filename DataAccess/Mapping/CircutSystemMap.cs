using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;

namespace DataAccess.Mapping
{
    public class CircutSystemMap : IEntityTypeConfiguration<CircutSystem>
    { 
        public void Configure(EntityTypeBuilder<CircutSystem> builder)
        {

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.IsDelete).IsRequired(true);
            builder.Property(r => r.IsWork).IsRequired(true);
            builder.Property(r => r.ReallyDeleted).IsRequired(true);
            builder.Property(r => r.ModifiedUserName).HasMaxLength(50);
            builder.Property(r => r.ModifiedUserName).IsRequired(true);
            builder.Property(r => r.ModifiedTime).IsRequired(true);
            builder.Property(r => r.CreateDate).IsRequired(true);
            builder.Property(r => r.CreateDate).HasColumnType("date");   
            builder.Property(r => r.CircutSystemStartDate).HasColumnType("date");
            builder.Property(r => r.CircutSystemFinishDate).HasColumnType("date");


       

        builder.Property(r => r.ProjectId).IsRequired(true);
            builder.Property(r => r.SystemName).IsRequired(true);
            builder.Property(r => r.SystemName).HasMaxLength(70);




            builder.HasOne<Project>(a => a.Project).WithMany(u => u.CircutSystem).HasForeignKey(a => a.ProjectId);
        }
    }
}




