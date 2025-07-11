using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.Entities.DataBaseTable.UsersData;

namespace Core.Concrete.Entities.DataBaseTable.SpoolTracking
{
    public class Branch : MpsStandardBaseEntity, IMpsEntity
    {
        public const string DefaultBranchName = "Bilgi Teknolojileri";
        public const string DefaultBranchDetail = "Ayrıntı Verileri";

        public string BranchName { get; set; } = DefaultBranchName;
        public string BranchDetail { get; set; } = DefaultBranchDetail;

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<EmployeeUser> EmployeeUsers { get; set; } = new List<EmployeeUser>();
        public ICollection<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();



        public Branch()
        {
            Employees = new List<Employee>();
            EmployeeUsers = new List<EmployeeUser>();
            EmployeeProjects = new List<EmployeeProject>();
        }
    }
}

 