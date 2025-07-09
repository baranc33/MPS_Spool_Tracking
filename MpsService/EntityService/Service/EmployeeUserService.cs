using Core.Concrete.Entities.DataBaseTable.UsersData;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class EmployeeUserService : GenericService<EmployeeUser>, IEmployeeUserService 
    {
        public EmployeeUserService( IUnitOfWork unitOfWork, IMpsGenericRepository<EmployeeUser> repository) : base(unitOfWork, repository)
        {
        }
    }
}
