using Core.Concrete.Entities.DataBaseTable.UsersData;
using Core.Concrete.ViewModels.Employee;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class EmployeeUserService : IEmployeeUserService
    {
     
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<EmployeeUser> _EntityRepository;
        public EmployeeUserService(IUnitOfWork unitOfWork, IMpsGenericRepository<EmployeeUser> EntityRepository)
        {
            _unitOfWork= unitOfWork;
            _EntityRepository = EntityRepository;
        }

       public async Task<EmployeeUserViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<EmployeeUserViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>CreateAsync(EmployeeUserViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>ModifiedAsync(EmployeeUserViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)> PassiveAsync(uint Id)
        {
            throw new NotImplementedException();
        }
    }
}
