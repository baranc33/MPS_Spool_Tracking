using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.Entities.DataBaseTable.UsersData;

namespace Core.Concrete.Entities.DataBaseTable.SpoolTracking
{
    public class Project: MpsStandartBaseEntity,IMpsEntity
    {

        // hangi tershaneye bağlı
        public ulong ShipYardId { get; set; }
        public ShipYard ShipYard { get; set; }

        public ICollection<CircutSystem> CircutSystem { get; set; }
        public ICollection<SpoolNavigator> SpoolNavigators { get; set; }
        public ICollection<EmployeeProject>  EmployeeProjects { get; set; }

   
        public DateTime ProjectStartDate { get; set; } = DateTime.Now;
        public DateTime? ProjectFinishDate { get; set; } = null; // proje bitiş tarihi opsiyonel olabilir. çünkü bitmeyen projeler var.


        // proje adı
        public string ProjectName { get; set; } 


        // Proje sorumlusu
        public ulong ProjectManagerId { get; set; }
        public EmployeeUser ProjectManager { get; set; }


        // toplam spool sayısı üstünden % hesaplaması için ayrılmış bi alan
        public ushort TotalSpoolCount { get; set; }



    }


}
