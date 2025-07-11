using Core.Concrete.Entities.BaseEntity;
using System.ComponentModel.DataAnnotations;

namespace Core.Concrete.ViewModels.ShipYard
{
    public class AddShipYardViewModel : MpsStandardBaseEntity
    {

        [Required(ErrorMessage = " Tersane Ad alanı boş bırakılamaz.")]
        [Display(Name = "Tersane Adı :")]
        [MinLength(5, ErrorMessage = "Tersane Adı en az 5 karakter olabilir")]
        [MaxLength(100, ErrorMessage = "Tersane Adı en Fazla 100 karakter olabilir")]
        public string ShipYardName { get; set; }

        [Required(ErrorMessage = " Tersane  Yönetici  Ad alanı boş bırakılamaz.")]
        [Display(Name = "Tersane Yönetici  Adı :")]
        [MinLength(5, ErrorMessage = "Tersane Yönetici Adı en az 5 karakter olabilir")]
        [MaxLength(100, ErrorMessage = "Tersane Yönetici Adı en Fazla 50 karakter olabilir")]
        public string ShipYardManagerName { get; set; }
        [Required(ErrorMessage = " Proje sayısı 1 den yüksek olmalıdır.")]
        public byte ShipYardActiveProject { get; set; }

    }
}
