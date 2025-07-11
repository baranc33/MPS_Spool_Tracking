using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.Brach;
using Core.Concrete.ViewModels.Employee;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;
using MpsService.Mapping.BranchAndEmployeeWork;

namespace MpsService.EntityService.Service
{
    public class BranchService : IBranchService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<Branch> _EntityRepository;
        public BranchService(IUnitOfWork unitOfWork, IMpsGenericRepository<Branch> EntityRepository)
        {
            _unitOfWork= unitOfWork;
            _EntityRepository = EntityRepository;
        }

        public async Task<(bool, string)> CreateAsync(BranchViewModel Entity)
        {
            //Branch branchs= await _EntityRepository.GetAsync(x=>x.BranchName==Entity.BranchName);
            //if (branchs!=null)
            //{

            //}
            //var result = await _EntityRepository.AddAsync(BranchMpsMapper.ToBranch(Entity));


            throw new NotImplementedException();

        }

        public async Task<ICollection<BranchViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<BranchViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<EmployeeViewModel>> GetBranchPersonelListWithInclude(uint Id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<EmployeeViewModel>> GetBranchPersonelListWithQuery(uint Id)
        {
            throw new NotImplementedException();
        }

        public async Task<(bool, string)>ModifiedAsync(BranchViewModel Entity)
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
