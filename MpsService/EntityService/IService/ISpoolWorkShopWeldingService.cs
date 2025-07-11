
using Core.Concrete.ViewModels.SpoolWorkShopWelding;

namespace MpsService.EntityService.IService
{
    public interface ISpoolWorkShopWeldingService
    {
 

        Task<SpoolWorkShopWeldingViewModel> GetAsync(uint Id);
        Task<ICollection<SpoolWorkShopWeldingViewModel>> GetAllAsync();
        Task<(bool, string)>CreateAsync(SpoolWorkShopWeldingViewModel Entity);
        Task<(bool, string)>ModifiedAsync(SpoolWorkShopWeldingViewModel Entity);
        Task<(bool, string)> PassiveAsync(uint Id);

    }
}
