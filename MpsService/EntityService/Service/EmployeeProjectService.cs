using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.ViewModels.Employee;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class EmployeeProjectService : IEmployeeProjectService
    {
    
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<EmployeeProject> _EntityRepository;
        public EmployeeProjectService(IUnitOfWork unitOfWork, IMpsGenericRepository<EmployeeProject> EntityRepository)
        {
            _unitOfWork= unitOfWork;
            _EntityRepository = EntityRepository;
        }

       public async Task<(bool, string)>CreateAsync(EmployeeProjectViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<EmployeeProjectViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       public async Task<EmployeeProjectViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>ModifiedAsync(EmployeeProjectViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)> PassiveAsync(uint Id)
        {
            throw new NotImplementedException();
        }
    }
}
