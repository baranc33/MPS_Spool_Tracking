using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.SpoolAssembly;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class SpoolAssemblyService :  ISpoolAssemblyService 
    {
   
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<SpoolAssembly> _EntityRepository;
        public SpoolAssemblyService(IUnitOfWork unitOfWork, IMpsGenericRepository<SpoolAssembly> EntityRepository)
        {
            _unitOfWork= unitOfWork;
            _EntityRepository = EntityRepository;
        }

       public async Task<(bool, string)>CreateAsync(SpoolAssemblyViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<SpoolAssemblyViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       public async Task<SpoolAssemblyViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>ModifiedAsync(SpoolAssemblyViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)> PassiveAsync(uint Id)
        {
            throw new NotImplementedException();
        }
    }
}
