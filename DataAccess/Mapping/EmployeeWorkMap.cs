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
            builder.Property(r => r.ModifiedUserName).HasMaxLength(50);
            builder.Property(r => r.ModifiedUserName).IsRequired(true);
            builder.Property(r => r.ModifiedTime).IsRequired(true);
            builder.Property(r => r.CreateDate).IsRequired(true);
            builder.Property(r => r.CreateDate).HasColumnType("date");

            builder.Property(r => r.WorkName).IsRequired(true);
            builder.Property(r => r.WorkName).HasMaxLength(70);


            builder.Property(r => r.WorkDetail).IsRequired(true);
            builder.Property(r => r.WorkDetail).HasMaxLength(200);
            builder.HasData(
             new EmployeeWork
             {
                 Id=1,
                 WorkName = "İmalat Ustası",
                 WorkDetail="Atolyede ön imalat yapan usta",
                 IsDelete = false,
                 IsWork = true,
                 ReallyDeleted = false,
                 ModifiedTime = DateTime.Now,
                 CreateDate = DateTime.Now,
                 ModifiedUserName = "System"
             },
            new EmployeeWork
            {
                Id=2,
                WorkName = "İmalat Ustası Yardımcısı",
                WorkDetail="Atolyede ön imalat yapan ustanın yardımcısı",
                IsDelete = false,
                IsWork = true,
                ReallyDeleted = false,
                ModifiedTime = DateTime.Now,
                CreateDate = DateTime.Now,
                ModifiedUserName = "System"
            },
            new EmployeeWork
            {
                Id=3,
                WorkName = "Kaynakçı ",
                WorkDetail="Atolyede Kaynak yapan usta",
                IsDelete = false,
                IsWork = true,
                ReallyDeleted = false,
                ModifiedTime = DateTime.Now,
                CreateDate = DateTime.Now,
                ModifiedUserName = "System"
            },
               new EmployeeWork
               {
                   Id=4,
                   WorkName = "Montaj Ustası ",
                   WorkDetail="Gemiye Montaj yapan usta",
                   IsDelete = false,
                   IsWork = true,
                   ReallyDeleted = false,
                   ModifiedTime = DateTime.Now,
                   CreateDate = DateTime.Now,
                   ModifiedUserName = "System"
               });

        }
    }
}
