using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Employee;
using Core.Concrete.ViewModels.Project;

namespace Core.Concrete.ViewModels.ShipYard
{
    public class ShipYardViewModel : MpsStandardBaseEntity
    {
        public string ShipYardName { get; set; }
        public string ShipYardManagerName { get; set; }
        public byte ShipYardActiveProject { get; set; }
        public ICollection<EmployeeViewModel> Employees { get; set; }
        public ICollection<ProjectViewModel> Projects { get; set; }


        public ShipYardViewModel()
        {
            Projects = new List<ProjectViewModel>();
            Employees = new List<EmployeeViewModel>();
            // Optionally, set a default name if truly required
            ShipYardManagerName = "Default Manager Name";
            ShipYardName = "Default Shipyard Name";
            ShipYardActiveProject=1;
        }

    }
}
