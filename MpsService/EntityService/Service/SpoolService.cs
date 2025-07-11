using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.Spool;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class SpoolService : ISpoolService
    {
     
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<Spool> _EntityRepository;
        public SpoolService(IUnitOfWork unitOfWork, IMpsGenericRepository<Spool> EntityRepository)
        {
            _unitOfWork= unitOfWork;
            _EntityRepository = EntityRepository;
        }

       public async Task<(bool, string)>CreateAsync(SpoolViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<SpoolViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       public async Task<SpoolViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>ModifiedAsync(SpoolViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)> PassiveAsync(uint Id)
        {
            throw new NotImplementedException();
        }
    }
}
