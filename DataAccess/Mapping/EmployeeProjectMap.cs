using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.Entities.DataBaseTable.UsersData;

namespace DataAccess.Mapping
{
    public class EmployeeProjectMap : IEntityTypeConfiguration<EmployeeProject>
    { 
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(r => r.IsDelete).IsRequired(true);
            builder.Property(r => r.IsWork).IsRequired(true);
            builder.Property(r => r.ReallyDeleted).IsRequired(true);



            builder.Property(r => r.BranchId).IsRequired(true);
            builder.Property(r => r.EmployeeId).IsRequired(true);
            builder.Property(r => r.ProjectId).IsRequired(true);
            builder.Property(r => r.StartDate).IsRequired(true);
            builder.Property(r => r.ManagerUserId).IsRequired(true);






            builder.HasOne<EmployeeWork>(a => a.EmployeeWork).WithMany(u => u.EmployeeProjects).HasForeignKey(a => a.EmployeeWorkId);
            builder.HasOne<Employee>(a => a.Employee).WithMany(u => u.EmployeeProjects).HasForeignKey(a => a.EmployeeId);
            builder.HasOne<Branch>(a => a.Branch).WithMany(u => u.EmployeeProjects).HasForeignKey(a => a.EmployeeId);
            builder.HasOne<Project>(a => a.Project).WithMany(u => u.EmployeeProjects).HasForeignKey(a => a.EmployeeId);
            builder.HasOne<EmployeeUser>(a => a.ManagerUser).WithMany(u => u.EmployeeProjects).HasForeignKey(a => a.ManagerUserId);

        }
    }
}




