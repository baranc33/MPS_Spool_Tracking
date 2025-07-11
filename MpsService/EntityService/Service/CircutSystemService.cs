using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.CircutSystem;
using Core.Concrete.ViewModels.Spool;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class CircutSystemService : ICircutSystemService
    {
     

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<CircutSystem> _EntityRepository;
        public CircutSystemService(IUnitOfWork unitOfWork, IMpsGenericRepository<CircutSystem> EntityRepository)
        {
            _unitOfWork= unitOfWork;
            _EntityRepository = EntityRepository;
        }

       public async Task<CircutSystemViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<CircutSystemViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<SpoolViewModel>> GetSystemSpoolListWithInclude(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<SpoolViewModel>> GetSystemSpoolListWithQuery(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>CreateAsync(CircutSystemViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>ModifiedAsync(CircutSystemViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)> RemoveAsync(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)> PassiveAsync(uint Id)
        {
            throw new NotImplementedException();
        }
    }
}
