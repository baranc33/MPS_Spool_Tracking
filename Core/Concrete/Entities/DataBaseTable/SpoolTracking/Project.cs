using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.Entities.DataBaseTable.UsersData;

namespace Core.Concrete.Entities.DataBaseTable.SpoolTracking
{
    public class Project: MpsStandartBaseEntity,IMpsEntity
    {

        // hangi tershaneye bağlı
        public ShipYard ShipYard { get; set; }
        public uint ShipYardId { get; set; }

        public ICollection<CircutSystem> CircutSystem { get; set; }
        public ICollection<SpoolNavigator> SpoolNavigators { get; set; }
        public ICollection<EmployeeProject>  EmployeeProjects { get; set; }


        public DateTime ProjectStartTime { get; set; } = DateTime.Now;
        public DateTime? ProjectFinishTime { get; set; } = null; // proje bitiş tarihi opsiyonel olabilir. çünkü bitmeyen projeler var.


        // proje adı
        public string ProjectName { get; set; } = "Kalaycı Denizcilik";


        // Proje sorumlusu
        public uint ProjectManagerId { get; set; }
        public EmployeeUser ProjectManager { get; set; }


        // toplam spool sayısı üstünden % hesaplaması için ayrılmış bi alan
        public uint TotalSpoolCount { get; set; }



        //projeye bağlı Blok listesi
        //public ICollection<Spool> spoolLists { get; set; }
        //public ICollection<PersonelProject> PersonelProjects { get; set; }




        // Proje genel bilgileri

        // Proje Adı
        // Projede Çalışan personeller
        // proje Yöneticisi
        // 
    }


}
