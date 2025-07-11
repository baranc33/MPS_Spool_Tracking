using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.ViewModels.Employee;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class EmployeeExitService : IEmployeeExitService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<EmployeeExit> _EntityRepository;
        public EmployeeExitService(IUnitOfWork unitOfWork, IMpsGenericRepository<EmployeeExit> EntityRepository)
        {
            _unitOfWork= unitOfWork;
            _EntityRepository = EntityRepository;
        }

       public async Task<(bool, string)>CreateAsync(EmployeeExitViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<EmployeeExitViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       public async Task<EmployeeExitViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>ModifiedAsync(EmployeeExitViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)> PassiveAsync(uint Id)
        {
            throw new NotImplementedException();
        }
    }
}
