using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class SpoolAssemblyService : GenericService<SpoolAssembly>, ISpoolAssemblyService 
    {
        public SpoolAssemblyService( IUnitOfWork unitOfWork, IMpsGenericRepository<SpoolAssembly> repository) : base(unitOfWork, repository)
        {
        }
    }
}
