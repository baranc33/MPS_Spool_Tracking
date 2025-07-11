using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Employee;

namespace Core.Concrete.ViewModels.Brach
{
    public class BranchViewModel : MpsStandardBaseEntity
    {

        public const string DefaultBranchName = "Bilgi Teknolojileri";
        public const string DefaultBranchDetail = "Ayrıntı Verileri";

        public string BranchName { get; set; } = DefaultBranchName;
        public string BranchDetail { get; set; } = DefaultBranchDetail;

        public ICollection<EmployeeViewModel> Employees { get; set; } = new List<EmployeeViewModel>();
        public ICollection<EmployeeUserViewModel> EmployeeUsers { get; set; } = new List<EmployeeUserViewModel>();
        public ICollection<EmployeeProjectViewModel> EmployeeProjects { get; set; } = new List<EmployeeProjectViewModel>();



        public BranchViewModel()
        {
            Employees = new List<EmployeeViewModel>();
            EmployeeUsers = new List<EmployeeUserViewModel>();
            EmployeeProjects = new List<EmployeeProjectViewModel>();
        }
    }
}

