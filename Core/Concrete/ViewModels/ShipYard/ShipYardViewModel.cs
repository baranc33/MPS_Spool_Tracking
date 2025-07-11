using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Employee;
using Core.Concrete.ViewModels.Project;

namespace Core.Concrete.ViewModels.ShipYard
{
    public class ShipYardViewModel : MpsStandartBaseEntity
    {
        // Tersane Adı
        public string ShipYardName { get; set; }

        // Tersane yöneticisi istenirse sadece isminin olacağı bağlantısız bi property.
        //public string ShipYardManagementName { get; set; } = "Abdurrahman Kalaycı";

        //Tershaneye Bağlı projeler burdan çağırılacak
        public ICollection<ProjectViewModel> Projects { get; set; }
        public ICollection<EmployeeViewModel> Employees { get; set; }
    }
}
