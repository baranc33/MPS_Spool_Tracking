using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class BranchMap : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
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
            //builder.Property(r => r.CreateDate.ToString("dd/MM/yyyy hh"));


            builder.Property(r => r.BranchName).IsRequired(true);
            builder.Property(r => r.BranchName).HasMaxLength(70);



            builder.Property(r => r.BranchDetail).IsRequired(true);
            builder.Property(r => r.BranchDetail).HasMaxLength(200);



            builder.HasData(
              new Branch
              {
                  Id=1,
                  BranchName = "Bilgi işlem",
                  BranchDetail="Bilgi işlem departmanı, şirketin bilgi teknolojileri altyapısını yönetir ve destekler.",
                  IsDeleted = false,
                  IsWork = true,
                  ReallyDeleted = false,
                  ModifiedTime = DateTime.Now,
                  CreateDate = DateTime.Now,
                  ModifiedUserName = "System",
                  LastBackupId = 0
              },
            new Branch
            {
                Id=2,
                BranchName = "Mühendis",
                BranchDetail="Boru Donatım Mühendisi.",
                IsDeleted = false,
                IsWork = true,
                ReallyDeleted = false,
                ModifiedTime = DateTime.Now,
                CreateDate = DateTime.Now,
                ModifiedUserName = "System",
                LastBackupId = 0
            },

              new Branch
              {
                  Id=3,
                  BranchName = "Mühendis",
                  BranchDetail="Boru Donatım Mühendisi.",
                  IsDeleted = false,
                  IsWork = true,
                  ReallyDeleted = false,
                  ModifiedTime = DateTime.Now,
                  CreateDate = DateTime.Now,
                  ModifiedUserName = "System",
                  LastBackupId = 0
              },
                new Branch
                {
                    Id=4,
                    BranchName = "Mühendis",
                    BranchDetail="Boru Donatım Mühendisi.",
                    IsDeleted = false,
                    IsWork = true,
                    ReallyDeleted = false,
                    ModifiedTime = DateTime.Now,
                    CreateDate = DateTime.Now,
                    ModifiedUserName = "System",
                    LastBackupId = 0
                },
                  new Branch
                  {
                      Id=5,
                      BranchName = "Mühendis",
                      BranchDetail="Boru Donatım Mühendisi.",
                      IsDeleted = false,
                      IsWork = true,
                      ReallyDeleted = false,
                      ModifiedTime = DateTime.Now,
                      CreateDate = DateTime.Now,
                      ModifiedUserName = "System",
                      LastBackupId = 0
                  },
                      new Branch
                      {
                          Id=6,
                          BranchName = "Atolye Şefi",
                          BranchDetail="Atolye işleyişinden sorumlu kişi.",
                          IsDeleted = false,
                          IsWork = true,
                          ReallyDeleted = false,
                          ModifiedTime = DateTime.Now,
                          CreateDate = DateTime.Now,
                          ModifiedUserName = "System",
                          LastBackupId = 0
                      }



            );
        }
    }
}




