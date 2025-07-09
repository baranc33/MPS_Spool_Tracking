using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class EmployeeWorkService : GenericService<EmployeeWork>, IEmployeeWorkService
    {
        public EmployeeWorkService( IUnitOfWork unitOfWork, IMpsGenericRepository<EmployeeWork> repository) : base(unitOfWork, repository)
        {
        }
    }
}
