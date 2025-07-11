using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Brach;
using Core.Concrete.ViewModels.ShipYard;
using System.ComponentModel.DataAnnotations;

namespace Core.Concrete.ViewModels.Employee
{
    public class AddEmployeeViewModel : MpsStandardBaseEntity
    {

        [Required(ErrorMessage = "Ad alanı boş bırakılamaz.")]
        [Display(Name = "Adı :")]
        [MinLength(3, ErrorMessage = "Adı en az 3 karakter olabilir")]
        [MaxLength(50, ErrorMessage = " Adı en Fazla 50 karakter olabilir")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soy Ad alanı boş bırakılamaz.")]
        [Display(Name = "Soy Adı :")]
        [MinLength(3, ErrorMessage = "Soy Adı en az 3 karakter olabilir")]
        [MaxLength(50, ErrorMessage = " Soy Adı en Fazla 50 karakter olabilir")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Sgk Numarası alanı boş bırakılamaz.")]
        [Display(Name = "Sgk Numarası :")]
        [MinLength(26, ErrorMessage = " Sgk Numarası 26 karakter olabilir")]
        [MaxLength(26, ErrorMessage = " Sgk Numarası26 karakter olabilir")]
        public string SgkRegistrationNumber { get; set; }

        [Required(ErrorMessage = "Tc Numarası alanı boş bırakılamaz.")]
        [Display(Name = "Tc Numarası :")]
        public ulong TcNumber { get; set; }

        [Required(ErrorMessage = "Doğum Tarihi Zorunlu .")]
        [Display(Name = "Doğum  Tarihi :")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDayDate { get; set; }

        [Required(ErrorMessage = "Cinsiyet alanı boş bırakılamaz.")]
        [Display(Name = "Cinsiyet :")]
        public bool Gender { get; set; }// True erkek False Kadın

        [Required(ErrorMessage = "Telefon Numarası alanı boş bırakılamaz.")]
        [Display(Name = "Telefon Numarası :")]
        public ulong Phone { get; set; }


        [Display(Name = "Resim:")]
        [MinLength(5, ErrorMessage = " Resim en az 5 karakter olabilir")]
        [MaxLength(50, ErrorMessage = " Resim en fazla 50karakter olabilir")]
        public string Picture { get; set; }

        [Required(ErrorMessage = "işe Başlama Tarihi Zorunlu .")]
        [Display(Name = "işe Başlama Tarihi :")]
        [DataType(DataType.DateTime)]
        public DateTime WorkStartDate { get; set; }

        [Required(ErrorMessage = "Sgk Branşını Giriniz .")]
        [Display(Name = "Sgk Branşını :")]
        public ulong BrancheId { get; set; }
        public ICollection<BranchViewModel> Branches { get; set; }

        [Required(ErrorMessage = "iş yeriBranşını Giriniz .")]
        [Display(Name = "iş yeri Branşını :")]
        public ulong EmployeeWorkId { get; set; }
        public ICollection<EmployeeWorkViewModel> EmployeeWorks { get; set; }//=> Personelin Yaptığı iş

        [Required(ErrorMessage = "iş yeri seçilmek Zorunda .")]
        [Display(Name = "Çalıştığı Yer:")]
        public ulong ShipYardId { get; set; }
        public ICollection<ShipYardViewModel> ShipYards { get; set; }

    }
}
