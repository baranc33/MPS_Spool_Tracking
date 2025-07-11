
using Core.Concrete.ViewModels.SpoolNavigator;

namespace MpsService.EntityService.IService
{
    public interface ISpoolNavigatorService
    {
        Task<SpoolNavigatorViewModel> GetAsync(uint Id);
        Task<ICollection<SpoolNavigatorViewModel>> GetAllAsync();
        Task<(bool, string)>CreateAsync(SpoolNavigatorViewModel Entity);
        Task<(bool, string)>ModifiedAsync(SpoolNavigatorViewModel Entity);
        Task<(bool, string)> PassiveAsync(uint Id);

    }

}
