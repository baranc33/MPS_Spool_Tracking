using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class ShipYardService : GenericService<ShipYard>, IShipYardService
    {
        public ShipYardService( IUnitOfWork unitOfWork, IMpsGenericRepository<ShipYard> repository) : base(unitOfWork, repository)
        {
        }
    }
}
