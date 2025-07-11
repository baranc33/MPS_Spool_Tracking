using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.Entities.DataBaseTable.UsersData;

namespace Core.Concrete.Entities.DataBaseTable.EmployeeData
{
    public class Employee : MpsStandartBaseEntity, IMpsEntity
    {
        // Sadece Personel Kaydı yapılırken Gerekecek Zorunlu bilgiler.
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SgkRegistrationNumber { get; set; }
        public string TcNumber { get; set; }
        public DateTime BirthDayDate { get; set; }
        public bool Gender { get; set; }// True erkek False Kadın
        public string Phone { get; set; }
        public string Picture { get; set; }
        public DateTime WorkStartDate { get; set; }



        public ulong BranchId { get; set; }
        public Branch Branch { get; set; }

        public ulong EmployeeWorkId { get; set; }
        public EmployeeWork EmployeeWork { get; set; }//=> Personelin Yaptığı iş


        public ulong ShipYardId { get; set; }
        public ShipYard ShipYard { get; set; }

        public EmployeeUser EmployeeUser { get; set; }
        public ICollection<EmployeeScoreCard> ScoreCard { get; set; }

        public ICollection<SpoolWorkShopWelding> SpoolWorkShopRootWelding { get; set; } //  Yaptığı Kaynaklar
        public ICollection<SpoolWorkShopWelding> SpoolWorkShopCoverWelding { get; set; } //  Yaptığı Kaynaklar
        public ICollection<SpoolWorkShopAssembly> SpoolWorkShopAssembly  { get; set; } // Yaptığı imalatlar
        public ICollection<SpoolAssembly> SpoolShipYardAssembly  { get; set; } // Yaptığı Montajlar

        public ICollection<EmployeeExit> EmployeeExits { get; set; }
        public ICollection<EmployeeProject> EmployeeProjects { get; set; }
        public ICollection<EmployeePoint> EmployeePoints { get; set; }
    }

}
