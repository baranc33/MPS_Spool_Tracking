using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class SpoolNavigatorService : GenericService<SpoolNavigator>, ISpoolNavigatorService
    {
        public SpoolNavigatorService( IUnitOfWork unitOfWork, IMpsGenericRepository<SpoolNavigator> repository) : base(unitOfWork, repository)
        {
        }
    }
}
