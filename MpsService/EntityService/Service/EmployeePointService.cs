using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class EmployeePointService : GenericService<EmployeePoint>, IEmployeePointService 
    {
        public EmployeePointService( IUnitOfWork unitOfWork, IMpsGenericRepository<EmployeePoint> repository) : base(unitOfWork, repository)
        {
        }
    }
}
