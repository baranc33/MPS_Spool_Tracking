using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.ViewModels.Employee;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class EmployeeWorkService :  IEmployeeWorkService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<EmployeeWork> _EntityRepository;
        public EmployeeWorkService( IUnitOfWork unitOfWork, IMpsGenericRepository<EmployeeWork> EntityRepository) 
        {
            _unitOfWork = unitOfWork;
            _EntityRepository = EntityRepository;
        }

        public async Task<(bool, string)>CreateAsync(EmployeeWorkViewModel Entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<EmployeeWorkViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<EmployeeWorkViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<EmployeeViewModel>> GetEmployeeWorkPersonelListWithInclude(uint Id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<EmployeeViewModel>> GetEmployeeWorkPersonelListWithQuery(uint Id)
        {
            throw new NotImplementedException();
        }

        public async Task<(bool, string)>ModifiedAsync(EmployeeWorkViewModel Entity)
        {
            throw new NotImplementedException();
        }

        public async Task<(bool, string)> PassiveAsync(uint Id)
        {
            throw new NotImplementedException();
        }

        public async Task<(bool, string)> RemoveAsync(uint Id)
        {
            throw new NotImplementedException();
        }
    }
}
