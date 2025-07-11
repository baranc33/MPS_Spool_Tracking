using Core.Concrete.ViewModels.SpoolWorkShopAssembly;

namespace MpsService.EntityService.IService
{
    public interface ISpoolWorkShopAssemblyService
    {
        Task<SpoolWorkShopAssemblyViewModel> GetAsync(uint Id);
        Task<ICollection<SpoolWorkShopAssemblyViewModel>> GetAllAsync();
        Task<(bool, string)>CreateAsync(SpoolWorkShopAssemblyViewModel Entity);
        Task<(bool, string)>ModifiedAsync(SpoolWorkShopAssemblyViewModel Entity);
        Task<(bool, string)> PassiveAsync(uint Id);

    }
}
