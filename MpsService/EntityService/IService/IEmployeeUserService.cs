

using Core.Concrete.ViewModels.Employee;

namespace MpsService.EntityService.IService
{
    public interface IEmployeeUserService
    {
        Task<EmployeeUserViewModel> GetAsync(uint Id);
        Task<ICollection<EmployeeUserViewModel>> GetAllAsync();
        Task<(bool, string)>CreateAsync(EmployeeUserViewModel Entity);
        Task<(bool, string)>ModifiedAsync(EmployeeUserViewModel Entity);
        Task<(bool, string)> PassiveAsync(uint Id);

    }

}
