using Core.Concrete.Entities.DataBaseTable.SingleEntity;
using Core.Concrete.ViewModels.Stock;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class StockService :   IStockService
    {
       
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<Stock> _EntityRepository;
        public StockService(IUnitOfWork unitOfWork, IMpsGenericRepository<Stock> EntityRepository)
        {
            _unitOfWork= unitOfWork;
            _EntityRepository = EntityRepository;
        }

       public async Task<(bool, string)>CreateAsync(StockViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<StockViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       public async Task<StockViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>ModifiedAsync(StockViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)> PassiveAsync(uint Id)
        {
            throw new NotImplementedException();
        }
    }
}
