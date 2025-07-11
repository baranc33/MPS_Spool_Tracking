using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class SpoolMap : IEntityTypeConfiguration<Spool>
    {
      
        public void Configure(EntityTypeBuilder<Spool> builder)
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
            //builder.Property(r => r.CuttingTime.ToString("dd/MM/yyyy hh:mm"));



            builder.Property(r => r.No).IsRequired(true);
            builder.Property(r => r.spoolStatus).IsRequired(true);
            builder.Property(r => r.Diameter).IsRequired(true);
            builder.Property(r => r.AssemblyOur).IsRequired(true);
            builder.Property(r => r.WorkPlaceOur).IsRequired(true);
            builder.Property(r => r.CircutSystemId).IsRequired(true);


            builder.Property(r => r.Note).HasMaxLength(100);
            builder.Property(r => r.Note).IsRequired(true);


            builder.Property(r => r.SpoolName).HasMaxLength(40);
            builder.Property(r => r.SpoolName).IsRequired(true);




            builder.HasOne(a => a.SpoolWorkShopAssembly).WithOne(u => u.Spool).HasForeignKey<SpoolWorkShopAssembly>(s => s.SpoolId);
            builder.HasOne(a => a.SpoolWorkShopWelding).WithOne(u => u.Spool).HasForeignKey<SpoolWorkShopWelding>(s => s.SpoolId);
            builder.HasOne(a => a.SpoolAssembly).WithOne(u => u.Spool).HasForeignKey<SpoolAssembly>(s => s.SpoolId);
            builder.HasOne(a => a.SpoolNavigator).WithOne(u => u.Spool).HasForeignKey<SpoolNavigator>(s => s.SpoolId);


            builder.HasOne<CircutSystem>(a => a.CircutSystem).WithMany(u => u.Spools).HasForeignKey(a => a.CircutSystemId);

        }
    }
}




