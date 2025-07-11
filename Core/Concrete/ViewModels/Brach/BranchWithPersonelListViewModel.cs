using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Employee;

namespace Core.Concrete.ViewModels.Brach
{
    public class BranchWithPersonelListViewModel : MpsStandardBaseEntity
    {


        public string BranchName { get; set; }
        public string BranchDetail { get; set; }


        public ICollection<EmployeeDetailViewModel> Employees { get; set; } = new List<EmployeeDetailViewModel>();
        
    }
}