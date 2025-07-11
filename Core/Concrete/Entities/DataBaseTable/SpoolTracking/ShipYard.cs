using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;

namespace Core.Concrete.Entities.DataBaseTable.SpoolTracking
{
    public class ShipYard : MpsStandardBaseEntity, IMpsEntity
    {
        public string ShipYardName { get; set; }
        public string ShipYardManagerName { get; set; }
        public byte ShipYardActiveProject { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Project> Projects { get; set; }


        public ShipYard()
        {
            Projects = new List<Project>();
            Employees = new List<Employee>();
            // Optionally, set a default name if truly required
            ShipYardManagerName = "Default Manager Name";
            ShipYardName = "Default Shipyard Name";
            ShipYardActiveProject=1;
        }

    }


}
