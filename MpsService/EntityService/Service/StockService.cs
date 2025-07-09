using Core.Concrete.Entities.DataBaseTable.SingleEntity;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class StockService : GenericService<Stock>, IStockService
    {
        public StockService(IUnitOfWork unitOfWork, IMpsGenericRepository<Stock> repository) : base(unitOfWork, repository)
        {
        }
    }
}
