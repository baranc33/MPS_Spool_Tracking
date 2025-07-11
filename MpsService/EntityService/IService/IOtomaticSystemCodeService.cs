
using Core.Concrete.ViewModels.OtomaticSystemCode;

namespace MpsService.EntityService.IService
{
    public interface IOtomaticSystemCodeService
    {
        Task<OtomaticSystemCodeViewModel> GetAsync(uint Id);
        Task<ICollection<OtomaticSystemCodeViewModel>> GetAllAsync();
        Task<(bool, string)>CreateAsync(OtomaticSystemCodeViewModel Entity);
        Task<(bool, string)>ModifiedAsync(OtomaticSystemCodeViewModel Entity);
        Task<(bool, string)> PassiveAsync(uint Id);

    }

}
