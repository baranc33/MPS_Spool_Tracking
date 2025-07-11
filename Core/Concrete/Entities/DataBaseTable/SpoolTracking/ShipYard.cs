using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;

namespace Core.Concrete.Entities.DataBaseTable.SpoolTracking
{
    public class ShipYard : MpsStandartBaseEntity, IMpsEntity
    {


        // Tersane Adı
        public string ShipYardName { get; set; } 

        // Tersane yöneticisi istenirse sadece isminin olacağı bağlantısız bi property.
        //public string ShipYardManagementName { get; set; } = "Abdurrahman Kalaycı";

        //Tershaneye Bağlı projeler burdan çağırılacak
        public ICollection<Project> Projects { get; set; }
        public ICollection<Employee>  Employees { get; set; }
 
    }



}
