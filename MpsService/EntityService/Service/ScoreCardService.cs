using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class ScoreCardService : GenericService<ScoreCard>, IScoreCardService
    {
        public ScoreCardService(IUnitOfWork unitOfWork, IMpsGenericRepository<ScoreCard> repository) : base(unitOfWork, repository)
        {
        }
    }
}
