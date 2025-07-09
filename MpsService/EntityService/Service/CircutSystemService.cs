using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class CircutSystemService : GenericService<CircutSystem>, ICircutSystemService
    {
        public CircutSystemService( IUnitOfWork unitOfWork, IMpsGenericRepository<CircutSystem> repository) : base(unitOfWork, repository)
        {
        }
    }
}
