using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class EmployeeExitService : GenericService<EmployeeExit>, IEmployeeExitService 
    {
        public EmployeeExitService( IUnitOfWork unitOfWork, IMpsGenericRepository<EmployeeExit> repository) : base(unitOfWork, repository)
        {
        }
    }
}
