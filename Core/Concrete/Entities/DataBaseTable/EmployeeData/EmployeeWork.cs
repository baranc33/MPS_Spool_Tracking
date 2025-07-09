using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.Entities.DataBaseTable.UsersData;

namespace Core.Concrete.Entities.DataBaseTable.EmployeeData
{
    public class EmployeeWork : MpsStandartBaseEntity, IMpsEntity
    {
        public string WorkName { get; set; } = "Bilgi işlem";
        public string WorkDetay { get; set; } = "Detay Verisi";




        public ICollection<Employee> Employees { get; set; }
        public ICollection<EmployeeUser> EmployeeUsers { get; set; }
        public ICollection<EmployeeProject> EmployeeProjects { get; set; }

    }
}
