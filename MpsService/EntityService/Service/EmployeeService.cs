using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.ViewModels.Employee;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class EmployeeService : IEmployeeService
    {
       
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<Employee> _EntityRepository;
        public EmployeeService(IUnitOfWork unitOfWork, IMpsGenericRepository<Employee> EntityRepository)
        {
            _unitOfWork= unitOfWork;
            _EntityRepository = EntityRepository;
        }

       public async Task<EmployeeViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<EmployeeViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>CreateAsync(EmployeeViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>ModifiedAsync(EmployeeViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)> PassiveAsync(uint Id)
        {
            throw new NotImplementedException();
        }
    }
}
