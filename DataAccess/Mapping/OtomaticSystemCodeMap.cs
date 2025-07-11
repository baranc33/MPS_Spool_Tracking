using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Concrete.Entities.DataBaseTable.SingleEntity;

namespace DataAccess.Mapping
{
    public class OtomaticSystemCodeMap : IEntityTypeConfiguration<OtomaticSystemCode> 
    { 
        public void Configure(EntityTypeBuilder<OtomaticSystemCode> builder)
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




            builder.Property(r => r.Title).HasMaxLength(50);
            builder.Property(r => r.Title).IsRequired(true);

            builder.Property(r => r.Description).HasMaxLength(100);
            builder.Property(r => r.Description).IsRequired(true);

            builder.Property(r => r.HashValue).HasMaxLength(200);
            builder.Property(r => r.HashValue).IsRequired(true);

            builder.Property(r => r.Value1).HasMaxLength(50);
            builder.Property(r => r.Value2).HasMaxLength(100);

        }
    }
}




