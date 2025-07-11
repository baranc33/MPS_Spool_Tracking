using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.SpoolWorkShopWelding;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class SpoolWorkShopWeldingService :   ISpoolWorkShopWeldingService
    {
    
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<SpoolWorkShopWelding> _EntityRepository;
        public SpoolWorkShopWeldingService(IUnitOfWork unitOfWork, IMpsGenericRepository<SpoolWorkShopWelding> EntityRepository)
        {
            _unitOfWork= unitOfWork;
            _EntityRepository = EntityRepository;
        }

       public async Task<(bool, string)>CreateAsync(SpoolWorkShopWeldingViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<SpoolWorkShopWeldingViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       public async Task<SpoolWorkShopWeldingViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>ModifiedAsync(SpoolWorkShopWeldingViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)> PassiveAsync(uint Id)
        {
            throw new NotImplementedException();
        }
    }
}
