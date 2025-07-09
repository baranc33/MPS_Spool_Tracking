using Core.Concrete.Entities.DataBaseTable.SingleEntity;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class OtomaticSystemCodeService : GenericService<OtomaticSystemCode>, IOtomaticSystemCodeService 
    {
        public OtomaticSystemCodeService( IUnitOfWork unitOfWork, IMpsGenericRepository<OtomaticSystemCode> repository) : base(unitOfWork, repository)
        {
        }
    }
}
