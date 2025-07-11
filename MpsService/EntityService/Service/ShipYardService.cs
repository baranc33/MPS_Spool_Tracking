using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.ShipYard;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class ShipYardService : IShipYardService
    {
    
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<ShipYard> _EntityRepository;
        public ShipYardService(IUnitOfWork unitOfWork, IMpsGenericRepository<ShipYard> EntityRepository)
        {
            _unitOfWork= unitOfWork;
            _EntityRepository = EntityRepository;
        }

       public async Task<(bool, string)>CreateAsync(ShipYardViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<ShipYardViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       public async Task<ShipYardViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>ModifiedAsync(ShipYardViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)> PassiveAsync(uint Id)
        {
            throw new NotImplementedException();
        }
    }
}
