using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.Entities.DataBaseTable.UsersData;

namespace DataAccess.Mapping
{
    public class BranchMap : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
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





            builder.Property(r => r.BranchName).IsRequired(true);
            builder.Property(r => r.BranchName).HasMaxLength(50);



            builder.Property(r => r.BranchDetay).IsRequired(true);
            builder.Property(r => r.BranchDetay).HasMaxLength(200);



            //builder.HasData(
            //  new Branch
            //  {
            //      Id=1,
            //      BranchName = "Bilgi işlem",
            //      BranchDetay="Bilgi işlem departmanı, şirketin bilgi teknolojileri altyapısını yönetir ve destekler.",
            //      IsDelete = false,
            //      IsWork = true,
            //      ReallyDeleted = false,
            //      CreateUser = "System",
            //      ModifiedTime = DateTime.Now,
            //      CreateTime = DateTime.Now,
            //      ModifiedUserName = "System"
            //  },
            //new Branch
            //{
            //    Id=2,
            //    BranchName = "Mühendis",
            //    BranchDetay="Boru Donatım Mühendisi.",
            //    IsDelete = false,
            //    IsWork = true,
            //    ReallyDeleted = false,
            //    CreateUser = "System",
            //    ModifiedTime = DateTime.Now,
            //    CreateTime = DateTime.Now,
            //    ModifiedUserName = "System"
            //}//,

              //new Branch
              //{
              //    Id=3,
              //    BranchName = "Mühendis",
              //    BranchDetay="Boru Donatım Mühendisi.",
              //    IsDelete = false,
              //    IsWork = true,
              //    ReallyDeleted = false,
              //    CreateUser = "System",
              //    ModifiedTime = DateTime.Now,
              //    CreateTime = DateTime.Now,
              //    ModifiedUserName = "System"
              //},
              //  new Branch
              //  {
              //      Id=4,
              //      BranchName = "Mühendis",
              //      BranchDetay="Boru Donatım Mühendisi.",
              //      IsDelete = false,
              //      IsWork = true,
              //      ReallyDeleted = false,
              //      CreateUser = "System",
              //      ModifiedTime = DateTime.Now,
              //      CreateTime = DateTime.Now,
              //      ModifiedUserName = "System"
              //  },
              //    new Branch
              //    {
              //        Id=5,
              //        BranchName = "Mühendis",
              //        BranchDetay="Boru Donatım Mühendisi.",
              //        IsDelete = false,
              //        IsWork = true,
              //        ReallyDeleted = false,
              //        CreateUser = "System",
              //        ModifiedTime = DateTime.Now,
              //        CreateTime = DateTime.Now,
              //        ModifiedUserName = "System"
              //    }



            //);
        }
    }
}




