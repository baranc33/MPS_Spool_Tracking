using Core.Concrete.ViewModels.Employee;

namespace MpsService.EntityService.IService
{
    public interface IEmployeeWorkService  
    {
        Task<EmployeeWorkViewModel> GetAsync(uint Id);
      
        Task<ICollection<EmployeeWorkViewModel>> GetAllAsync();
        Task<ICollection<EmployeeViewModel>> GetEmployeeWorkPersonelListWithInclude(uint Id);
        Task<ICollection<EmployeeViewModel>> GetEmployeeWorkPersonelListWithQuery(uint Id);
        Task<(bool, string)>CreateAsync(EmployeeWorkViewModel Entity);
        Task<(bool, string)>ModifiedAsync(EmployeeWorkViewModel Entity);
        Task<(bool, string)> RemoveAsync(uint Id);
        Task<(bool, string)> PassiveAsync(uint Id);
    }
}
