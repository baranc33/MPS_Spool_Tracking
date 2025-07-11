using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;

namespace DataAccess.Mapping
{
    public class SpoolNavigatorMap : IEntityTypeConfiguration<SpoolNavigator> 
    {
        public void Configure(EntityTypeBuilder<SpoolNavigator> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.IsDelete).IsRequired(true);
            builder.Property(r => r.IsWork).IsRequired(true);
            builder.Property(r => r.ReallyDeleted).IsRequired(true);


            builder.Property(r => r.ProjectId).IsRequired(true);

            builder.Property(r => r.CircutSystemId).IsRequired(true);
            builder.Property(r => r.SpoolId).IsRequired(true);
            builder.Property(r => r.SpoolAssemblyId).IsRequired(true);
            builder.Property(r => r.SpoolWorkShopAssemblyId).IsRequired(true);
            builder.Property(r => r.SpoolWorkShopWeldingId).IsRequired(true);




            builder.HasOne<Project>(a => a.Project).WithMany(u => u.SpoolNavigators).HasForeignKey(a => a.ProjectId);
            builder.HasOne<CircutSystem>(a => a.CircutSystem).WithMany(u => u.SpoolNavigators).HasForeignKey(a => a.CircutSystemId);

        }
    }
}




