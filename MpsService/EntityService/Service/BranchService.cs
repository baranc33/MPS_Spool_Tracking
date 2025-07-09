using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class BranchService : GenericService<Branch>, IBranchService 
    {
        public BranchService( IUnitOfWork unitOfWork, IMpsGenericRepository<Branch> repository) : base(unitOfWork, repository)
        {
        }
    }
}
