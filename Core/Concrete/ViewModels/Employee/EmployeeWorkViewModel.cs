using Core.Concrete.Entities.BaseEntity;
using System.ComponentModel.DataAnnotations;

namespace Core.Concrete.ViewModels.Employee
{
    public class EmployeeWorkViewModel : MpsStandardBaseEntity
    {
      



        [Required(ErrorMessage = "Çalıştığı Branş Ad alanı boş bırakılamaz.")]
        [Display(Name = "Çalıştığı Branş  Adı :")]
        [MinLength(5, ErrorMessage = "Çalıştığı Branş  Adı en az 5 karakter olabilir")]
        [MaxLength(70, ErrorMessage = "Çalıştığı Branş  Adı en Fazla 70 karakter olabilir")]
        public string WorkName { get; set; } = "Bilgi işlem";
        [Required(ErrorMessage = "Çalıştığı Branş  Detay alanı boş bırakılamaz.")]
        [Display(Name = "Çalıştığı Branş  Detay :")]
        [MinLength(5, ErrorMessage = "Çalıştığı Branş  Detay en az 5 karakter olabilir")]
        [MaxLength(70, ErrorMessage = "Çalıştığı Branş   Detay en Fazla 70 karakter olabilir")]
        public string WorkDetail { get; set; } = "Detay Verisi";





        public ICollection<EmployeeViewModel> Employees { get; set; } = new List<EmployeeViewModel>();
        public ICollection<EmployeeUserViewModel> EmployeeUsers { get; set; } = new List<EmployeeUserViewModel>();
        public ICollection<EmployeeProjectViewModel> EmployeeProjects { get; set; } = new List<EmployeeProjectViewModel>();
    }
}
