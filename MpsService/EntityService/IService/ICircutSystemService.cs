using Core.Concrete.ViewModels.CircutSystem;
using Core.Concrete.ViewModels.Spool;

namespace MpsService.EntityService.IService
{
    public interface ICircutSystemService  
    {


        Task<CircutSystemViewModel> GetAsync(uint Id);
        Task<ICollection<CircutSystemViewModel>> GetAllAsync();
        Task<ICollection<SpoolViewModel>> GetSystemSpoolListWithInclude(uint Id);
        Task<ICollection<SpoolViewModel>> GetSystemSpoolListWithQuery(uint Id);
        Task<(bool, string)> CreateAsync(CircutSystemViewModel Entity);
        Task<(bool, string)> ModifiedAsync(CircutSystemViewModel Entity);
        Task<(bool, string)> RemoveAsync(uint Id);
        Task<(bool, string)> PassiveAsync(uint Id);
    }
  
}
