using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class SpoolWorkShopAssemblyMap : IEntityTypeConfiguration<SpoolWorkShopAssembly>
    {
        public void Configure(EntityTypeBuilder<SpoolWorkShopAssembly> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(r => r.IsDelete).IsRequired(true);
            builder.Property(r => r.IsWork).IsRequired(true);
            builder.Property(r => r.ReallyDeleted).IsRequired(true);

            builder.Property(r => r.SpoolId).IsRequired(true);


            builder.HasOne(a => a.SpoolNavigator).WithOne(u => u.SpoolWorkShopAssembly).HasForeignKey<SpoolNavigator>(s => s.SpoolWorkShopAssemblyId);


            builder.HasOne<Employee>(a => a.AssemblyEmployee).WithMany(u => u.SpoolWorkShopAssembly).HasForeignKey(a => a.AssemblyEmployeeId);

            

        }
    }
}



