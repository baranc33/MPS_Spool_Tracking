using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class EmployeePointMap : IEntityTypeConfiguration<EmployeePoint>
    {
        public void Configure(EntityTypeBuilder<EmployeePoint> builder)
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





            builder.Property(r => r.EmployeeId).IsRequired(true);
            builder.Property(r => r.TeamWorkPoint).IsRequired(true);
            builder.Property(r => r.JabTrackingPoint).IsRequired(true);
            builder.Property(r => r.ContinuityPoint).IsRequired(true);
            builder.Property(r => r.AveragePoint).IsRequired(true);
            builder.Property(r => r.GiveDateFinish).IsRequired(true);
            builder.Property(r => r.GiveDateFinish).HasColumnType("date");
            builder.Property(r => r.GiveDateStart).IsRequired(true);
            builder.Property(r => r.GiveDateStart).HasColumnType("date");




            builder.Property(r => r.UserNameGivePoint).HasMaxLength(50);
            builder.Property(r => r.UserNameGivePoint).IsRequired(true);


            builder.Property(r => r.UserId).HasMaxLength(50);
            builder.Property(r => r.UserId).IsRequired(true);


            builder.HasOne<Employee>(a => a.Employee).WithMany(u => u.EmployeePoints).HasForeignKey(a => a.EmployeeId);
        }
    }
}




