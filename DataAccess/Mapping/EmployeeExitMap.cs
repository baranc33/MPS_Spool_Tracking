using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;

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

            builder.Property(r => r.ModifiedUserName).IsRequired(true);
            builder.Property(r => r.ModifiedTime).IsRequired(true);
            builder.Property(r => r.CreateUser).IsRequired(true);
            builder.Property(r => r.CreateTime).IsRequired(true);


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




