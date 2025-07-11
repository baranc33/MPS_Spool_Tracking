using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Employee;
using Core.Concrete.ViewModels.Project;

namespace Core.Concrete.ViewModels.ShipYard
{
    public class ShipYardDetailsViewModel : MpsStandardBaseEntity
    {
        public string ShipYardName { get; set; }
        public string ShipYardManagerName { get; set; }
        public byte ShipYardActiveProject { get; set; }
        public ICollection<EmployeeViewModel> Employees { get; set; } = new List<EmployeeViewModel>();
        public ICollection<ProjectViewModel> Projects { get; set; } = new List<ProjectViewModel>();

        public byte ActiveProjectCount { get; set; }
        public ICollection<string> ProjectsName{ get; set; }
        public ulong TotalSpoolCount{ get; set; }
        public ulong FinishSpoolCount{ get; set; }


        public EmployeeUserViewModel ManagerEmployeeUser { get; set; } = new EmployeeUserViewModel();

    }
}
