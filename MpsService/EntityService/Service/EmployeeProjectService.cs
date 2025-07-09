using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class EmployeeProjectService : GenericService<EmployeeProject>, IEmployeeProjectService 
    {
        public EmployeeProjectService( IUnitOfWork unitOfWork, IMpsGenericRepository<EmployeeProject> repository) : base(unitOfWork, repository)
        {
        }
    }
}
