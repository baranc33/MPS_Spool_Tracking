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
            builder.Property(r => r.IsDeleted).IsRequired(true);
            builder.Property(r => r.IsWork).IsRequired(true);
            builder.Property(r => r.ReallyDeleted).IsRequired(true);
            builder.Property(r => r.ModifiedUserName).HasMaxLength(50);
            builder.Property(r => r.ModifiedUserName).IsRequired(true);
            builder.Property(r => r.ModifiedTime).IsRequired(true);
            builder.Property(r => r.CreateDate).IsRequired(true);
            builder.Property(r => r.CreateDate).HasColumnType("date");

            //builder.Property(r => r.CreateDate.ToString("dd/MM/yyyy hh"));
            //builder.Property(r => r.ModifiedTime.ToString("dd/MM/yyyy hh:mm"));
            //builder.Property(r => r.AssemblyTime.ToString("dd/MM/yyyy hh:mm"));


            builder.Property(r => r.SpoolId).IsRequired(true);


            builder.HasOne(a => a.SpoolNavigator).WithOne(u => u.SpoolWorkShopAssembly).HasForeignKey<SpoolNavigator>(s => s.SpoolWorkShopAssemblyId);


            builder.HasOne<Employee>(a => a.SpoolWorkShopAssemblyEmployee).WithMany(u => u.SpoolWorkShopAssembly).HasForeignKey(a => a.SpoolWorkShopAssemblyEmployeeId);

            

        }
    }
}



