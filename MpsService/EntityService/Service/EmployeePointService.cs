using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.ViewModels.Employee;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class EmployeePointService : IEmployeePointService
    {
       
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<EmployeePoint> _EntityRepository;
        public EmployeePointService(IUnitOfWork unitOfWork, IMpsGenericRepository<EmployeePoint> EntityRepository)
        {
            _unitOfWork= unitOfWork;
            _EntityRepository = EntityRepository;
        }

       public async Task<EmployeePointViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<EmployeePointViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>CreateAsync(EmployeePointViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>ModifiedAsync(EmployeePointViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)> PassiveAsync(uint Id)
        {
            throw new NotImplementedException();
        }
    }
}
