using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.SpoolWorkShopAssembly;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class SpoolWorkShopAssemblyService :   ISpoolWorkShopAssemblyService 
    {
    
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<SpoolWorkShopAssembly> _EntityRepository;
        public SpoolWorkShopAssemblyService(IUnitOfWork unitOfWork, IMpsGenericRepository<SpoolWorkShopAssembly> EntityRepository)
        {
            _unitOfWork= unitOfWork;
            _EntityRepository = EntityRepository;
        }

       public async Task<(bool, string)>CreateAsync(SpoolWorkShopAssemblyViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<SpoolWorkShopAssemblyViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       public async Task<SpoolWorkShopAssemblyViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>ModifiedAsync(SpoolWorkShopAssemblyViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)> PassiveAsync(uint Id)
        {
            throw new NotImplementedException();
        }
    }
}
