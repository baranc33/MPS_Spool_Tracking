using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Brach;
using Core.Concrete.ViewModels.ScoreCard;
using Core.Concrete.ViewModels.ShipYard;
using Core.Concrete.ViewModels.SpoolAssembly;
using Core.Concrete.ViewModels.SpoolWorkShopAssembly;
using Core.Concrete.ViewModels.SpoolWorkShopWelding;

namespace Core.Concrete.ViewModels.Employee
{
    public class EmployeeDetailViewModel : MpsStandardBaseEntity
    {
        // Sadece Personel Kaydı yapılırken Gerekecek Zorunlu bilgiler.
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SgkRegistrationNumber { get; set; }
        public string TcNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public bool Gender { get; set; }// True erkek False Kadın
        public string Phone { get; set; }

        public DateTime WorkStartDate { get; set; }



        public ulong BranchId { get; set; }
        public BranchViewModel Branch { get; set; }

        public ulong EmployeeWorkId { get; set; }
        public EmployeeWorkViewModel EmployeeWork { get; set; }//=> Personelin Yaptığı iş


        public ulong ShipYardId { get; set; }
        public ShipYardViewModel ShipYard { get; set; }

        public EmployeeUserViewModel EmployeeUser { get; set; }
        public ICollection<EmployeeScoreCardViewModel> ScoreCard { get; set; }

        public ICollection<SpoolWorkShopWeldingViewModel> SpoolWorkShopWelding { get; set; } //  Yaptığı Kaynaklar
        public ICollection<SpoolWorkShopAssemblyViewModel> SpoolWorkShopAssembly { get; set; } // Yaptığı imalatlar
        public ICollection<SpoolAssemblyViewModel> SpoolShipYardAssembly { get; set; } // Yaptığı Montajlar

        public ICollection<EmployeeExitViewModel> EmployeeExits { get; set; }
        public ICollection<EmployeeProjectViewModel> EmployeeProjects { get; set; }
        public ICollection<EmployeePointViewModel> EmployeePoints { get; set; }
    }
}
