using Core.Concrete.Entities.DataBaseTable.SingleEntity;
using Core.Concrete.ViewModels.OtomaticSystemCode;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class OtomaticSystemCodeService : IOtomaticSystemCodeService
    {
    
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<OtomaticSystemCode> _EntityRepository;
        public OtomaticSystemCodeService(IUnitOfWork unitOfWork, IMpsGenericRepository<OtomaticSystemCode> EntityRepository)
        {
            _unitOfWork= unitOfWork;
            _EntityRepository = EntityRepository;
        }

       public async Task<OtomaticSystemCodeViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<OtomaticSystemCodeViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>CreateAsync(OtomaticSystemCodeViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>ModifiedAsync(OtomaticSystemCodeViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)> PassiveAsync(uint Id)
        {
            throw new NotImplementedException();
        }
    }
}
