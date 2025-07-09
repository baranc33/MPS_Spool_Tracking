using Core.Concrete.Entities.DataBaseTable.UsersData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class MpsRoleMap : IEntityTypeConfiguration<MpsRole>
    {
        public void Configure(EntityTypeBuilder<MpsRole> builder)
        {



            builder.HasData(
                
              new MpsRole
              {
                  Id = "1",
                  Name = "Admin",
                  NormalizedName = "ADMIN",
                  ConcurrencyStamp = Guid.NewGuid().ToString()
              },
              new MpsRole
              {
                  Id = "2",
                  Name = "Manager",
                  NormalizedName = "MANAGER",
                  ConcurrencyStamp = Guid.NewGuid().ToString()
              }, new MpsRole
              {
                  Id = "3",
                  Name = "WorkShopManager",
                  NormalizedName = "WORKSHOPMANAGER",
                  ConcurrencyStamp = Guid.NewGuid().ToString()
              }, new MpsRole
              {
                  Id = "4",
                  Name = "WorkShopEmployee",
                  NormalizedName = "WORKSHOPEMPLOYEE",
                  ConcurrencyStamp = Guid.NewGuid().ToString()
              },
              new MpsRole
              {
                  Id = "5",
                  Name = "TallyClerk",
                  NormalizedName = "TALLYCLERK",
                  ConcurrencyStamp = Guid.NewGuid().ToString()
              }, new MpsRole
              {
                  Id = "6",
                  Name = "ChefEngineer",
                  NormalizedName = "CHEFENGINEERR",
                  ConcurrencyStamp = Guid.NewGuid().ToString()
              }, 
              new MpsRole
              {
                  Id = "7",
                  Name = "Engineer",
                  NormalizedName = "ENGINEER",
                  ConcurrencyStamp = Guid.NewGuid().ToString()
              }
              , new MpsRole
              {
                  Id = "8",
                  Name = "Stock",
                  NormalizedName = "STOCK".ToUpper(),
                  ConcurrencyStamp = Guid.NewGuid().ToString()
              }, new MpsRole
              {
                  Id = "9",
                  Name = "TrackingUser",
                  NormalizedName = "TrackingUser".ToUpper(),
                  ConcurrencyStamp = Guid.NewGuid().ToString()
              }

                );
        }
    }
}




