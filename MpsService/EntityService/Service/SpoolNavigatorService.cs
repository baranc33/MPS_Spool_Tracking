using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.SpoolNavigator;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class SpoolNavigatorService :  ISpoolNavigatorService
    {
  
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<SpoolNavigator> _EntityRepository;
        public SpoolNavigatorService(IUnitOfWork unitOfWork, IMpsGenericRepository<SpoolNavigator> EntityRepository)
        {
            _unitOfWork= unitOfWork;
            _EntityRepository = EntityRepository;
        }

       public async Task<(bool, string)>CreateAsync(SpoolNavigatorViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<SpoolNavigatorViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       public async Task<SpoolNavigatorViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>ModifiedAsync(SpoolNavigatorViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)> PassiveAsync(uint Id)
        {
            throw new NotImplementedException();
        }
    }
}
