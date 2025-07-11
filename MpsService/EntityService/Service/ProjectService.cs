using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.Project;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class ProjectService : IProjectService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<Project> _EntityRepository;
        public ProjectService(IUnitOfWork unitOfWork, IMpsGenericRepository<Project> EntityRepository)
        {
            _unitOfWork= unitOfWork;
            _EntityRepository = EntityRepository;
        }

       public async Task<(bool, string)>CreateAsync(ProjectViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<ICollection<ProjectViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       public async Task<ProjectViewModel> GetAsync(uint Id)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)>ModifiedAsync(ProjectViewModel Entity)
        {
            throw new NotImplementedException();
        }

       public async Task<(bool, string)> PassiveAsync(uint Id)
        {
            throw new NotImplementedException();
        }
    }
}
