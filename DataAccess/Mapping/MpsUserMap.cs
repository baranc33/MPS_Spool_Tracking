using Core.Concrete.Entities.DataBaseTable.UsersData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class MpsUserMap : IEntityTypeConfiguration<MpsUser>
    {



        public void Configure(EntityTypeBuilder<MpsUser> builder)
        {
           
            builder.Property(r => r.UserName).HasMaxLength(50);
            builder.Property(r => r.NormalizedUserName).HasMaxLength(50);



            builder.Property(r => r.ReallyDeleted).IsRequired(true);
            builder.Property(r => r.UseForPersonel).IsRequired(true);

            builder.Property(r => r.PasswordBackUp).HasMaxLength(20);
            builder.Property(r => r.PasswordBackUp).IsRequired(true);


            builder.HasOne(a => a.EmployeeUser).WithOne(u => u.User).HasForeignKey<EmployeeUser>(s => s.UserId);

        }
    }
}
