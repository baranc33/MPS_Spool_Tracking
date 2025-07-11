using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Employee;
using Core.Concrete.ViewModels.ShipYard;
using System.ComponentModel.DataAnnotations;

namespace Core.Concrete.ViewModels.Project
{
    public class AddProjectViewModel : MpsStandardBaseEntity
    {

        [Required(ErrorMessage = "Tersane alanı boş bırakılamaz.")]
        [Display(Name = "Tersane Adı :")]
        public ulong ShipYardId { get; set; }

        public ICollection<ShipYardViewModel> shipYards { get; set; }

        [Required(ErrorMessage = "Projeye Başlama Tarihi Zorunlu")]
        [Display(Name = " Projeye Başlama Tarihi")]
        [DataType(DataType.Date)] // Specify the appropriate DataType enumeration value
        public DateTime ProjectStartDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Proje Adı alanı boş bırakılamaz.")]
        [Display(Name = "Proje Adı :")]
        [MinLength(5, ErrorMessage = "Proje Adı en az 5 karakter olabilir")]
        [MaxLength(100, ErrorMessage = "Proje Adı en Fazla 100 karakter olabilir")]
        public string ProjectName { get; set; } = "1";

        [Required(ErrorMessage = "Proje Sorumlusu alanı boş bırakılamaz.")]
        [Display(Name = "Proje Sorumlusu :")]
        public ulong ProjectManagerId { get; set; }
        public ICollection<EmployeeUserViewModel> ProjectManagers { get; set; }



        [Required(ErrorMessage = "Proje Toplam Spool Sayısını Giriniz.")]
        [Display(Name = "Projedeki Spool sayısı:")]
        public ushort TotalSpoolCount { get; set; }

    }









}
