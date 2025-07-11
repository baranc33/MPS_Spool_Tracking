using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.ViewModels.ScoreCard;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class ScoreCardService : IScoreCardService
    {
      
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<EmployeeScoreCard> _EntityRepository;
        public ScoreCardService(IUnitOfWork unitOfWork, IMpsGenericRepository<EmployeeScoreCard> EntityRepository)
        {
            _unitOfWork= unitOfWork;
            _EntityRepository = EntityRepository;
        }

       public async Task<(bool, string)>CreateAsync(EmployeeScoreCardViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<EmployeeScoreCardViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       public async Task<EmployeeScoreCardViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>ModifiedAsync(EmployeeScoreCardViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)> PassiveAsync(uint Id)
        {
            throw new NotImplementedException();
        }
    }
}
