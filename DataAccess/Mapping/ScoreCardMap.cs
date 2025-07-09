using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class ScoreCardMap : IEntityTypeConfiguration<ScoreCard>
    {
        public void Configure(EntityTypeBuilder<ScoreCard> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(r => r.IsDelete).IsRequired(true);
            builder.Property(r => r.IsWork).IsRequired(true);
            builder.Property(r => r.ReallyDeleted).IsRequired(true);

            builder.Property(r => r.ModifiedUserName).IsRequired(true);
            builder.Property(r => r.ModifiedTime).IsRequired(true);
            builder.Property(r => r.CreateUser).IsRequired(true);
            builder.Property(r => r.CreateTime).IsRequired(true);



            builder.HasOne<Employee>(a => a.Employee).WithMany(u => u.ScoreCard).HasForeignKey(a => a.EmployeeId);
        }
    }
}
