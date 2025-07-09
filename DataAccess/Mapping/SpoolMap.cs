using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;

namespace DataAccess.Mapping
{
    public class SpoolMap : IEntityTypeConfiguration<Spool>
    {
        public void Configure(EntityTypeBuilder<Spool> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(r => r.IsDelete).IsRequired(true);
            builder.Property(r => r.IsWork).IsRequired(true);
            builder.Property(r => r.ReallyDeleted).IsRequired(true);


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




