using Core.Concrete.Entities.DataBaseTable.SingleEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
   
    public class StockMap : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
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
            builder.Property(r => r.EntryTime).IsRequired(true);
            builder.Property(r => r.CreateDate).HasColumnType("date");

            //builder.Property(r => r.CreateDate.ToString("dd/MM/yyyy hh"));
            //builder.Property(r => r.ModifiedTime.ToString("dd/MM/yyyy hh:mm"));
            //builder.Property(r => r.EntryTime.ToString("dd/MM/yyyy hh:mm"));
            //builder.Property(r => r.ExitTime.ToString("dd/MM/yyyy hh:mm"));


            //builder.Property(r => r.CreateDate).Must(BirthDateValidator).WithMessage("Error date!");

            builder.Property(r => r.Name).IsRequired(true);
            builder.Property(r => r.Name).HasMaxLength(50);



            builder.Property(r => r.Content).IsRequired(true);
            builder.Property(r => r.Content).HasMaxLength(150);


            builder.Property(r => r.SenderName).HasMaxLength(100);

        }
    }
}
