
using Core.Concrete.ViewModels.Project;

namespace MpsService.EntityService.IService
{
    public interface IProjectService
    {
        Task<ProjectViewModel> GetAsync(uint Id);
        Task<ICollection<ProjectViewModel>> GetAllAsync();
        Task<(bool, string)>CreateAsync(ProjectViewModel Entity);
        Task<(bool, string)>ModifiedAsync(ProjectViewModel Entity);
        Task<(bool, string)> PassiveAsync(uint Id);

    }

}
