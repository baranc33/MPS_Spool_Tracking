using Core.Concrete.Entities.DataBaseTable.UsersData;
using DataAccess.EntitiesRepostory;
using Microsoft.AspNetCore.Identity;
using MpsDevelopment.Models.CustomValidasyon;

namespace MpsDevelopment.Models.Extentions.Programcs
{
    public static class CustomIdentitySettings
    {
        public static void AddIdentityWitjExtentions(this IServiceCollection services)
        {



            services.AddIdentity<MpsUser, MpsRole>(opt =>
            {
                opt.User.RequireUniqueEmail = true; // Id Zorunlu
                opt.User.AllowedUserNameCharacters = "öÖğĞüÜşŞçÇabcdefghiıjklmnopqrstuvwxyzABCDEFGHIİIJKLMNOPQRSTUVWXYZ0123456789-._@+";// kullanılabilecek karakterler

                opt.Password.RequiredLength = 6; // Şifre uzunluğu
                opt.Password.RequireDigit = true; // Şifre rakam içermeli
                opt.Password.RequireLowercase = true; // Şifre küçük harf içermeli
                opt.Password.RequireUppercase = true; // Şifre büyük harf içermeli
                opt.Password.RequireNonAlphanumeric = false; // Şifre özel karakter içermelimi
                opt.SignIn.RequireConfirmedPhoneNumber = false; // Telefon onayı zorunlu mu
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(60); // Kilitleme süresi
                opt.Lockout.MaxFailedAccessAttempts = 15; // Maksimum deneme sayısı



            })
                .AddPasswordValidator<PasswordValidator>()
                .AddUserValidator<UserValidator>()
                .AddErrorDescriber<LocalizationIdentityErrorDescriber>() // hata mesajlarını türkçeleştirmek için localization kullanıyoruz
                .AddEntityFrameworkStores<MpsDbContext>();// ef hangisini kullanacak belirtiyoruz.

        }
    }
}
