using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class EmployeeExitMap : IEntityTypeConfiguration<EmployeeExit>
    { 
        public void Configure(EntityTypeBuilder<EmployeeExit> builder)
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
            builder.Property(r => r.WorkStartDate).HasColumnType("date");
            builder.Property(r => r.WorkFinishDate).HasColumnType("date");




            builder.Property(r => r.EmployeeId).IsRequired(true);

            builder.Property(r => r.TeamWorkAveragePoint).IsRequired(true);
            builder.Property(r => r.JabTrackingAveragePoint).IsRequired(true);
            builder.Property(r => r.ContinuityAveragePoint).IsRequired(true);
            builder.Property(r => r.AveragePoint).IsRequired(true);
            builder.Property(r => r.WorkFinishDate).IsRequired(true);
            builder.Property(r => r.WorkStartDate).IsRequired(true);


            builder.Property(r => r.ExitNote).HasMaxLength(200);
            builder.Property(r => r.ExitNote).IsRequired(true);

     


            builder.Property(r => r.EmployeeProjects).HasMaxLength(100);
            builder.Property(r => r.EmployeeProjects).IsRequired(true);

            builder.HasOne<Employee>(a => a.Employee).WithMany(u => u.EmployeeExits).HasForeignKey(a => a.EmployeeId);
        }
    }
}




