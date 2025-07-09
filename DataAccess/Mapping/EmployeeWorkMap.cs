using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class EmployeeWorkMap : IEntityTypeConfiguration<EmployeeWork>
    {
        public void Configure(EntityTypeBuilder<EmployeeWork> builder)
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

            builder.HasData(
             new EmployeeWork
             {
                 Id=1,
                 WorkName = "İmalat Ustası",
                 WorkDetay="Atolyede ön imalat yapan usta",
                 IsDelete = false,
                 IsWork = true,
                 ReallyDeleted = false,
                 CreateUser = "System",
                 ModifiedTime = DateTime.Now,
                 CreateTime = DateTime.Now,
                 ModifiedUserName = "System"
             },
            new EmployeeWork
            {
                Id=2,
                WorkName = "İmalat Ustası Yardımcısı",
                WorkDetay="Atolyede ön imalat yapan ustanın yardımcısı",
                IsDelete = false,
                IsWork = true,
                ReallyDeleted = false,
                CreateUser = "System",
                ModifiedTime = DateTime.Now,
                CreateTime = DateTime.Now,
                ModifiedUserName = "System"
            },
            new EmployeeWork
            {
                Id=3,
                WorkName = "Kaynakçı ",
                WorkDetay="Atolyede Kaynak yapan usta",
                IsDelete = false,
                IsWork = true,
                ReallyDeleted = false,
                CreateUser = "System",
                ModifiedTime = DateTime.Now,
                CreateTime = DateTime.Now,
                ModifiedUserName = "System"
            },
               new EmployeeWork
               {
                   Id=4,
                   WorkName = "Montaj Ustası ",
                   WorkDetay="Gemiye Montaj yapan usta",
                   IsDelete = false,
                   IsWork = true,
                   ReallyDeleted = false,
                   CreateUser = "System",
                   ModifiedTime = DateTime.Now,
                   CreateTime = DateTime.Now,
                   ModifiedUserName = "System"
               });

        }
    }
}
