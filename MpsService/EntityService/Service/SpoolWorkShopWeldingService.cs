using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class SpoolWorkShopWeldingService : GenericService<SpoolWorkShopWelding>, ISpoolWorkShopWeldingService
    {
        public SpoolWorkShopWeldingService(IUnitOfWork unitOfWork, IMpsGenericRepository<SpoolWorkShopWelding> repository) : base(unitOfWork, repository)
        {
        }
    }
}
