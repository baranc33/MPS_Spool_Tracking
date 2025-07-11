using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.ScoreCard;
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
        public ulong TcNumber { get; set; }
        public DateTime BirthDayDate { get; set; }
        public bool Gender { get; set; }// True erkek False Kadın
        public ulong Phone { get; set; }
        public DateTime WorkStartDate { get; set; }
        public string Picture { get; set; }




        public string BranchName { get; set; } 


        public string EmployeeWorkName { get; set; } 
        public string ShipYardName { get; set; } 
  

        public EmployeeUserViewModel EmployeeUser { get; set; }


        public ICollection<EmployeeScoreCardViewModel> ScoreCard { get; set; }

        public ICollection<SpoolWorkShopWeldingViewModel> SpoolWorkShopWelding { get; set; } = new List<SpoolWorkShopWeldingViewModel>(); //  Yaptığı Kaynaklar
        public ICollection<SpoolWorkShopAssemblyViewModel> SpoolWorkShopAssembly { get; set; }=new List<SpoolWorkShopAssemblyViewModel>(); // Yaptığı imalatlar
        public ICollection<SpoolAssemblyViewModel> SpoolShipYardAssembly { get; set; } = new List<SpoolAssemblyViewModel>(); // Yaptığı Montajlar

        public ICollection<EmployeeExitViewModel> EmployeeExits { get; set; } = new List<EmployeeExitViewModel>();
        public ICollection<EmployeeProjectViewModel> EmployeeProjects { get; set; }= new List<EmployeeProjectViewModel>();
        public ICollection<EmployeePointViewModel> EmployeePoints { get; set; } = new List<EmployeePointViewModel>();
    }
}
