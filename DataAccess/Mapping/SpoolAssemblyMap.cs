using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;

namespace DataAccess.Mapping
{
    public class SpoolAssemblyMap : IEntityTypeConfiguration<SpoolAssembly> 
    { 
        public void Configure(EntityTypeBuilder<SpoolAssembly> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(r => r.IsDelete).IsRequired(true);
            builder.Property(r => r.IsWork).IsRequired(true);
            builder.Property(r => r.ReallyDeleted).IsRequired(true);

            builder.Property(r => r.SpoolId).IsRequired(true);



            builder.HasOne(a => a.SpoolNavigator).WithOne(u => u.SpoolAssembly).HasForeignKey<SpoolNavigator>(s => s.SpoolAssemblyId);

            builder.HasOne<Employee>(a => a.AssemblyEmployee).WithMany(u => u.SpoolShipYardAssembly).HasForeignKey(a => a.AssemblyEmployeeId);

        }

    }
}




