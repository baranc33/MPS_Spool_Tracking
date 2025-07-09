using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class EmployeeService : GenericService<Employee>, IEmployeeService
    {
        public EmployeeService( IUnitOfWork unitOfWork, IMpsGenericRepository<Employee> repository) : base(unitOfWork, repository)
        {
        }
    }
}
