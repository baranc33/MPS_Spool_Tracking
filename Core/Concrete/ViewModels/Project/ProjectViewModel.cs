using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.CircutSystem;
using Core.Concrete.ViewModels.Employee;
using Core.Concrete.ViewModels.SpoolNavigator;

namespace Core.Concrete.ViewModels.Project
{
    public class ProjectViewModel : MpsStandartBaseEntity
    {
        // hangi tershaneye bağlı
        public string ShipYardName { get; set; }

        public ICollection<CircutSystemViewModel> CircutSystem { get; set; }
        public ICollection<SpoolNavigatorViewModel> SpoolNavigators { get; set; }
        public ICollection<EmployeeProjectViewModel> EmployeeProjects { get; set; }


        public DateTime ProjectStartDate { get; set; } = DateTime.Now;
        public DateTime? ProjectFinishDate { get; set; } = null; // proje bitiş tarihi opsiyonel olabilir. çünkü bitmeyen projeler var.


        // proje adı
        public string ProjectName { get; set; }


        // Proje sorumlusu
        public ulong ProjectManagerId { get; set; }
        public EmployeeUserViewModel ProjectManager { get; set; }


        // toplam spool sayısı üstünden % hesaplaması için ayrılmış bi alan
        public uint TotalSpoolCount { get; set; }


 
    }
}
