
using Core.Concrete.ViewModels.ShipYard;

namespace MpsService.EntityService.IService
{
    public interface IShipYardService
    {
        Task<ShipYardViewModel> GetAsync(uint Id);
        Task<ICollection<ShipYardViewModel>> GetAllAsync();
        Task<(bool, string)>CreateAsync(ShipYardViewModel Entity);
        Task<(bool, string)>ModifiedAsync(ShipYardViewModel Entity);
        Task<(bool, string)> PassiveAsync(uint Id);


    }

}
