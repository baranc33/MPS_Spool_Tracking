
using Core.Concrete.ViewModels.Employee;

namespace MpsService.EntityService.IService
{
    public interface IEmployeePointService
    {

        Task<EmployeePointViewModel> GetAsync(uint Id);
        Task<ICollection<EmployeePointViewModel>> GetAllAsync();
        Task<(bool, string)> CreateAsync(EmployeePointViewModel Entity);
        Task<(bool, string)> ModifiedAsync(EmployeePointViewModel Entity);
        Task<(bool, string)> PassiveAsync(uint Id);

    }
}
