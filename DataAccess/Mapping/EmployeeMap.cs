using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.Entities.DataBaseTable.UsersData;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;

namespace DataAccess.Mapping
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    { 
        public void Configure(EntityTypeBuilder<Employee> builder)
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
            builder.Property(r => r.BirthDayDate).IsRequired(true);
            builder.Property(r => r.BirthDayDate).HasColumnType("date");
            builder.Property(r => r.WorkStartDate).HasColumnType("date");





            builder.Property(r => r.Name).IsRequired(true);
            builder.Property(r => r.Name).HasMaxLength(50);

            builder.Property(r => r.LastName).IsRequired(true);
            builder.Property(r => r.LastName).HasMaxLength(50);

            builder.Property(r => r.SgkRegistrationNumber).IsRequired(true);
            builder.Property(r => r.SgkRegistrationNumber).HasMaxLength(50);


            builder.Property(r => r.TcNumber).IsRequired(true);
            builder.Property(r => r.TcNumber).HasMaxLength(11);



            builder.Property(r => r.Phone).HasMaxLength(15);
            builder.Property(r => r.Phone).IsRequired(true);

            builder.Property(r => r.WorkStartDate).IsRequired(true);
            builder.Property(r => r.BranchId).IsRequired(true);
            builder.Property(r => r.ShipYardId).IsRequired(true);







            //builder.HasOne(a => a.WorkPlace).WithOne(u => u.spool).HasForeignKey<WorkPlace>(s => s.spoolId);
     
            builder.HasOne(a => a.EmployeeUser).WithOne(u => u.Employee).HasForeignKey<EmployeeUser>(s => s.EmployeeId);


            builder.HasOne<EmployeeWork>(a => a.EmployeeWork).WithMany(u => u.Employees).HasForeignKey(a => a.EmployeeWorkId);
            builder.HasOne<Branch>(a => a.Branch).WithMany(u => u.Employees).HasForeignKey(a => a.BranchId);
            builder.HasOne<ShipYard>(a => a.ShipYard).WithMany(u => u.Employees).HasForeignKey(a => a.ShipYardId);
            

        }
    }
}




