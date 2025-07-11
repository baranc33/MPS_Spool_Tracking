using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.Entities.DataBaseTable.UsersData;

namespace Core.Concrete.Entities.DataBaseTable.EmployeeData
{
    
    public class EmployeeWork : MpsStandardBaseEntity, IMpsEntity
    {
        public const string DefaultWorkName = "Bilgi işlem";
        public const string DefaultWorkDetail = "Detay Verisi";

        public string WorkName { get; set; }
        public string WorkDetail { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<EmployeeUser> EmployeeUsers { get; set; }
        public ICollection<EmployeeProject> EmployeeProjects { get; set; }

        public EmployeeWork()
        {
            WorkName = DefaultWorkName;
            WorkDetail = DefaultWorkDetail;
            Employees = new List<Employee>();
            EmployeeUsers = new List<EmployeeUser>();
            EmployeeProjects = new List<EmployeeProject>();
        }
    }
}
