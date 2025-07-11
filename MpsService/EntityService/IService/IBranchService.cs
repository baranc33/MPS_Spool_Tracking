using Core.Concrete.ViewModels.Brach;
using Core.Concrete.ViewModels.Employee;

namespace MpsService.EntityService.IService
{
    public interface IBranchService 
    {
       



        Task<BranchViewModel> GetAsync(uint Id);
        Task<ICollection<BranchViewModel>> GetAllAsync();
        Task<ICollection<EmployeeViewModel>> GetBranchPersonelListWithInclude(uint Id);
        Task<ICollection<EmployeeViewModel>> GetBranchPersonelListWithQuery(uint Id);
        Task<(bool, string)> CreateAsync(BranchViewModel Entity);
        Task<(bool, string)> ModifiedAsync(BranchViewModel Entity);
        Task<(bool,string)> RemoveAsync(uint Id);
        Task<(bool, string)> PassiveAsync(uint Id);

    }
}
