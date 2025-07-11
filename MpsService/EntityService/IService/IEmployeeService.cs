
using Core.Concrete.ViewModels.Employee;

namespace MpsService.EntityService.IService
{
    public interface IEmployeeService
    {
        Task<EmployeeViewModel> GetAsync(uint Id);
        Task<ICollection<EmployeeViewModel>> GetAllAsync();
        Task<(bool, string)>CreateAsync(EmployeeViewModel Entity);
        Task<(bool, string)>ModifiedAsync(EmployeeViewModel Entity);
        Task<(bool, string)> PassiveAsync(uint Id);

    }
}
