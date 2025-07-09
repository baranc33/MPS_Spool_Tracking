using Core.Concrete.Entities.DataBaseTable.UsersData;
using Microsoft.AspNetCore.Identity;

namespace MpsDevelopment.Models.CustomValidasyon
{
    public class PasswordValidator : IPasswordValidator<MpsUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<MpsUser> manager, MpsUser user, string password)
        {


            var errors = new List<IdentityError>();
            if (password!.ToLower().Contains(user.UserName!.ToLower()))
            {
                errors.Add(new() { Code = "PasswordContainUserName", Description = "Şifre alanı kullanıcı adı içeremez" });
            }

            if (password!.ToLower().StartsWith("1234"))
            {
                errors.Add(new() { Code = "PasswordContain1234", Description = "Şifre alanı ardışık sayı içeremez" });
            }

            if (errors.Any())
            {
                return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            }

            return Task.FromResult(IdentityResult.Success);


        }
    }
}