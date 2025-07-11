using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Employee;

namespace Core.Concrete.ViewModels.Brach
{
    public class BranchWithEmployeeProjectListViewModel : MpsStandartBaseEntity
    {



        public string BranchName { get; set; }
        public string BranchDetail { get; set; }




        public ICollection<EmployeeProjectDetailViewModel> EmployeeProjects { get; set; } = new List<EmployeeProjectDetailViewModel>();
    }
}