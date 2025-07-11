using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.Entities.DataBaseTable.UsersData;

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
            builder.Property(r => r.ModifiedUserName).HasMaxLength(50);
            builder.Property(r => r.ModifiedUserName).IsRequired(true);
            builder.Property(r => r.ModifiedTime).IsRequired(true);
            builder.Property(r => r.CreateDate).IsRequired(true);
            builder.Property(r => r.CreateDate).HasColumnType("date");


            
            builder.Property(r => r.SpoolId).IsRequired(true);

            //builder.Property(r => r.CreateDate.ToString("dd/MM/yyyy h:"));
            //builder.Property(r => r.ModifiedTime.ToString("dd/MM/yyyy h:mm"));
            //builder.Property(r => r.AssemblyTime.ToString("dd/MM/yyyy h:mm"));






            builder.HasOne(a => a.SpoolNavigator).WithOne(u => u.SpoolAssembly).HasForeignKey<SpoolNavigator>(s => s.SpoolAssemblyId);

            builder.HasOne<Employee>(a => a.AssemblyEmployee).WithMany(u => u.SpoolShipYardAssembly).HasForeignKey(a => a.AssemblyEmployeeId);
            builder.HasOne<EmployeeUser>(a => a.AssemblyEngineer).WithMany(u => u.AssemblyCheck).HasForeignKey(a => a.AssemblyEngineerId);

        }

    }
}




