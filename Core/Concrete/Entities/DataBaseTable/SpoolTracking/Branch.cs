using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.Entities.DataBaseTable.UsersData;

namespace Core.Concrete.Entities.DataBaseTable.SpoolTracking
{
    public class Branch : MpsStandartBaseEntity, IMpsEntity
    {

        public string BranchName { get; set; } = "Bilgi işlem";
        public string BranchDetay { get; set; } = "Detay Verisi";




        public ICollection<Employee> Employees { get; set; }
        public ICollection<EmployeeUser> EmployeeUsers { get; set; }
        public ICollection<EmployeeProject> EmployeeProjects { get; set; }


    }
}
