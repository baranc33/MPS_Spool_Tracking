using Core.Concrete.ViewModels.Spool;

namespace MpsService.EntityService.IService
{
    public interface ISpoolService
    {
        Task<SpoolViewModel> GetAsync(uint Id);
        Task<ICollection<SpoolViewModel>> GetAllAsync();
        Task<(bool, string)>CreateAsync(SpoolViewModel Entity);
        Task<(bool, string)>ModifiedAsync(SpoolViewModel Entity);
        Task<(bool, string)> PassiveAsync(uint Id);

    }

}
