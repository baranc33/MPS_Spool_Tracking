using Core.Concrete.ViewModels.SpoolAssembly;

namespace MpsService.EntityService.IService
{
    public interface ISpoolAssemblyService
    {
        Task<SpoolAssemblyViewModel> GetAsync(uint Id);
        Task<ICollection<SpoolAssemblyViewModel>> GetAllAsync();
        Task<(bool, string)>CreateAsync(SpoolAssemblyViewModel Entity);
        Task<(bool, string)>ModifiedAsync(SpoolAssemblyViewModel Entity);
        Task<(bool, string)> PassiveAsync(uint Id);

    }

}
