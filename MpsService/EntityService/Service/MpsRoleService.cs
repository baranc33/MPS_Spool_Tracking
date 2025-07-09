using Core.Concrete.Entities.DataBaseTable.UsersData;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class MpsRoleService : GenericService<MpsRole>, IMpsRoleService 
    {
        public MpsRoleService( IUnitOfWork unitOfWork, IMpsGenericRepository<MpsRole> repository) : base(unitOfWork, repository)
        {
        }
    }
}
