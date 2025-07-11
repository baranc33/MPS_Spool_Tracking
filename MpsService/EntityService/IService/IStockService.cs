using Core.Concrete.ViewModels.Stock;

namespace MpsService.EntityService.IService
{
    public interface IStockService
    {
        Task<StockViewModel> GetAsync(uint Id);
        Task<ICollection<StockViewModel>> GetAllAsync();
        Task<(bool, string)>CreateAsync(StockViewModel Entity);
        Task<(bool, string)>ModifiedAsync(StockViewModel Entity);
        Task<(bool, string)> PassiveAsync(uint Id);



    }
}
