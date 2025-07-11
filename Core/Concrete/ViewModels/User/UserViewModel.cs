
using System.ComponentModel.DataAnnotations;

namespace Core.Concrete.ViewModels.User
{
    public class UserViewModel
    {

        public string Id { get; set; }
      
        [Required(ErrorMessage = "Kullanıcı Ad alanı boş bırakılamaz.")]
        [Display(Name = "Kullanıcı Adı :")]
        [MinLength(6, ErrorMessage = "Kullanıcı Adı en az 6 karakter olabilir")]
        [MaxLength(50, ErrorMessage = "Kullanıcı Adı en Fazla 50 karakter olabilir")]
        public string UserName { get; set; } = null!;

      
        [EmailAddress(ErrorMessage = "Email formatı yanlıştır.")]
        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [MaxLength(100, ErrorMessage = "  Email en Fazla 100 karakter olabilir")]
        [Display(Name = "Email :")]
        public string Email { get; set; } = null!;
        public string PasswordBackUp { get; set; }

         
        public string PhoneNumber { get; set; }
        public bool ReallyDeleted { get; set; }
        public bool UseForPersonel { get; set; }

        public DateTime ModifiedTime { get; set; }  //=>  En Son Güncellenme Tarihi.
        public string ModifiedUserName { get; set; } //=> En Son Güncelliyen Kişi.
        public uint? LastBackUpId { get; set; } //=> Son Yapılan Değişikliğin Kaydını Tutan Id.
        public DateTime CreateTime { get; set; }  //==> Nesnenin ilk Oluşturulduğu Tarih.
    }
}
