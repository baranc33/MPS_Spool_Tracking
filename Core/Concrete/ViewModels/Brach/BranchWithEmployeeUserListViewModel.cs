using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Employee;

namespace Core.Concrete.ViewModels.Brach
{
    public class BranchWithEmployeeUserListViewModel : MpsStandartBaseEntity
    {



        public string BranchName { get; set; }
        public string BranchDetail { get; set; }




        public ICollection<EmployeeUserDetailViewModel> EmployeeUsers { get; set; } = new List<EmployeeUserDetailViewModel>();
    }
}