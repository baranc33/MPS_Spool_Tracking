using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class ScoreCardMap : IEntityTypeConfiguration<EmployeeScoreCard>
    {
        public void Configure(EntityTypeBuilder<EmployeeScoreCard> builder)
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
            builder.Property(r => r.DayDate).IsRequired(true);
            builder.Property(r => r.DayDate).HasColumnType("date");


            builder.HasOne<Employee>(a => a.Employee).WithMany(u => u.ScoreCard).HasForeignKey(a => a.EmployeeId);
        }
    }
}
