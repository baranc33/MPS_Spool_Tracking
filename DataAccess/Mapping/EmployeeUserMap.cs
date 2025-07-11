using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Concrete.Entities.DataBaseTable.UsersData;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;

namespace DataAccess.Mapping
{
    public class EmployeeUserMap : IEntityTypeConfiguration<EmployeeUser> 
    { 
        public void Configure(EntityTypeBuilder<EmployeeUser> builder)
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







            builder.Property(r => r.UserId).HasMaxLength(50);
            builder.Property(r => r.UserId).IsRequired(true);
            builder.Property(r => r.BranchId).IsRequired(true);
            builder.Property(r => r.EmployeeId).IsRequired(true);


            builder.Property(r => r.Linkedin).HasMaxLength(100);
            builder.Property(r => r.Linkedin).IsRequired(true);


            builder.Property(r => r.Picture).IsRequired(true);

            builder.HasOne<EmployeeWork>(a => a.EmployeeWork).WithMany(u => u.EmployeeUsers).HasForeignKey(a => a.EmployeeWorkId);
            builder.HasOne<Branch>(a => a.Branch).WithMany(u => u.EmployeeUsers).HasForeignKey(a => a.BranchId);


            builder.HasOne(a => a.Project).WithOne(u => u.ProjectManager).HasForeignKey<Project>(s => s.ProjectManagerId);
        }
    }
}




