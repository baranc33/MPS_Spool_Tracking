using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Project;
using System.ComponentModel.DataAnnotations;

namespace Core.Concrete.ViewModels.CircutSystem
{
    public class AddCircutSystemViewModel : MpsStandardBaseEntity
    {
        [Required(ErrorMessage = "Devreye Başlama Tarihi Zorunlu")]
        [Display(Name = "Devreye Başlama Tarihi")]
        [DataType(DataType.Date)] // Specify the appropriate DataType enumeration value
        public DateTime CircutSystemStartDate { get; set; }

        [Required(ErrorMessage = "Devre Ad alanı boş bırakılamaz.")]
        [Display(Name = "DevreAdı :")]
        [MinLength(5, ErrorMessage = "DevreAdı en az 5 karakter olabilir")]
        [MaxLength(70, ErrorMessage = "Devre Adı en Fazla 70 karakter olabilir")]
        public string SystemName { get; set; }

        [Required(ErrorMessage = "Devre deki Toplam Spool Sayısı boş bırakılamaz.")]
        [Display(Name = "Devre deki Toplam Spool Sayısı :")]
        public ushort TotalSpoolCount { get; set; }

        [Required(ErrorMessage = "Devre  Projeye Bağlı olmak zorunda:")]
        [Display(Name = "Proje")]
        public ulong ProjectId { get; set; }

        public ICollection<ProjectViewModel> Projects { get; set; }
    }
}
