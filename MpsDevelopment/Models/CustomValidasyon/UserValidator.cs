using Core.Concrete.Entities.DataBaseTable.UsersData;
using Microsoft.AspNetCore.Identity;

namespace MpsDevelopment.Models.CustomValidasyon
{
    public class UserValidator : IUserValidator<MpsUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<MpsUser> manager, MpsUser user)
        {
            var errors = new List<IdentityError>();
            var isDigit = int.TryParse(user.UserName![0].ToString(), out _);
            // ilk değer numerikmi diye kontrol ediyoruz , ikinci parametre değeri dönüyor fakat biz kullanmıyoruz

            if (isDigit)
            {
                errors.Add(new() { Code = "UserNameContainFirstLetterDigit", Description = "Kullanıcı adının ilk karekteri sayısal bir karakter içeremez" });
            }

            if (errors.Any())
            {
                return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            }

            return Task.FromResult(IdentityResult.Success);
        }
    }
}