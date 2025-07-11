using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.CircutSystem;
using Core.Concrete.ViewModels.Employee;
using Core.Concrete.ViewModels.ShipYard;
using Core.Concrete.ViewModels.SpoolNavigator;

namespace Core.Concrete.ViewModels.Project
{
    public class ProjectViewModel : MpsStandardBaseEntity
    {

        // Associated shipyard
        public ShipYardViewModel ShipYard { get; set; }
        public ulong ShipYardId { get; set; }

        // List of circuit systems for the project
        public ICollection<CircutSystemViewModel> CircutSystems { get; set; }
        public ICollection<SpoolNavigatorViewModel> SpoolNavigators { get; set; }
        public ICollection<EmployeeProjectViewModel> EmployeeProjects { get; set; }

        public DateTime ProjectStartDate { get; set; } = DateTime.Now;
        public DateTime? ProjectFinishDate { get; set; } = null; // proje bitiş tarihi opsiyonel olabilir. çünkü bitmeyen projeler var.

        // proje adı
        public string ProjectName { get; set; } = "1";

        // Proje sorumlusu
        public ulong ProjectManagerId { get; set; }
        public EmployeeUserViewModel ProjectManager { get; set; }


        // toplam spool sayısı üstünden % hesaplaması için ayrılmış bi alan
        public ushort TotalSpoolCount { get; set; }

    }














}
