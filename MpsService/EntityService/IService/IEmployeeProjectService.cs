
using Core.Concrete.ViewModels.Employee;

namespace MpsService.EntityService.IService
{
    public interface IEmployeeProjectService
    {
        Task<EmployeeProjectViewModel> GetAsync(uint Id);
        Task<ICollection<EmployeeProjectViewModel>> GetAllAsync();
        Task<(bool, string)> CreateAsync(EmployeeProjectViewModel Entity);
        Task<(bool, string)> ModifiedAsync(EmployeeProjectViewModel Entity);
        Task<(bool, string)> PassiveAsync(uint Id);

    }
}
