using Core.Concrete.Entities.BaseEntity;
using System.ComponentModel.DataAnnotations;

namespace Core.Concrete.ViewModels.Brach
{
    public class AddBranchViewModel : MpsStandardBaseEntity
    {

        [Required(ErrorMessage = "Sgk Branş Ad alanı boş bırakılamaz.")]
        [Display(Name = "Sgk Branş Adı :")]
        [MinLength(5, ErrorMessage = "Sgk Branş Adı en az 5 karakter olabilir")]
        [MaxLength(70, ErrorMessage = "Sgk Branş Adı en Fazla 70 karakter olabilir")]
        public string BranchName { get; set; }

        [Required(ErrorMessage = "Sgk Branş Detay alanı boş bırakılamaz.")]
        [Display(Name = "Sgk Branş Detay :")]
        [MinLength(5, ErrorMessage = "Sgk Branş Detay en az 5 karakter olabilir")]
        [MaxLength(70, ErrorMessage = "Sgk Branş Detay en Fazla 200 karakter olabilir")]
        public string BranchDetail { get; set; }

    }
}

