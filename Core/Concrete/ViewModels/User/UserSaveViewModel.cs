using System.ComponentModel.DataAnnotations;

namespace Core.Concrete.ViewModels.User
{
    public class UserSaveViewModel
    {
        public UserSaveViewModel()
        {
            
        }
        public UserSaveViewModel(string userName, string email,   string password,string passwordConfirm)
        {
            UserName = userName;
            Email = email;

            Password = password;
            PasswordConfirm = passwordConfirm;

        }
        [Required(ErrorMessage = "Kullanıcı Ad alanı boş bırakılamaz.")]
        [Display(Name = "Kullanıcı Adı :")]
        [MinLength(6, ErrorMessage = "Kullanıcı Adı en az 6 karakter olabilir")]
        public string UserName { get; set; } = null!;

        [EmailAddress(ErrorMessage = "Email formatı yanlıştır.")]
        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [Display(Name = "Email :")]
        public string Email { get; set; } = null!;

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [Display(Name = "Şifre :")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir")]
        public string Password { get; set; } = null!;

        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Şifre aynı değildir.")]
        [Required(ErrorMessage = "Şifre tekrar alanı boş bırakılamaz")]
        [Display(Name = "Şifre Tekrar :")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir")]
        public string PasswordConfirm { get; set; } = null!;

        public string PhoneNumber { get; set; }
        public bool ReallyDeleted { get; set; }
        public bool UseForPersonel { get; set; }
        public string ModifiedUserName { get; set; }


    }
}
