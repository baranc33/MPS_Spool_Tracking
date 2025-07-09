using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class SpoolWorkShopAssemblyService : GenericService<SpoolWorkShopAssembly>, ISpoolWorkShopAssemblyService 
    {
        public SpoolWorkShopAssemblyService(IUnitOfWork unitOfWork, IMpsGenericRepository<SpoolWorkShopAssembly> repository) : base(unitOfWork, repository)
        {
        }
    }
}
