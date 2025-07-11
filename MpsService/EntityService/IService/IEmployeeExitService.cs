using Core.Concrete.ViewModels.Employee;

namespace MpsService.EntityService.IService
{
    public interface IEmployeeExitService  
    {
        Task<EmployeeExitViewModel> GetAsync(uint Id);
        Task<ICollection<EmployeeExitViewModel>> GetAllAsync();
        Task<(bool, string)> CreateAsync(EmployeeExitViewModel Entity);
        Task<(bool, string)> ModifiedAsync(EmployeeExitViewModel Entity);
        Task<(bool, string)> PassiveAsync(uint Id);

    }
}
