using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;

namespace MpsService.EntityService.Service
{
    public class ProjectService : GenericService<Project>, IProjectService 
    {
        public ProjectService( IUnitOfWork unitOfWork, IMpsGenericRepository<Project> repository) : base(unitOfWork, repository)
        {
        }
    }
}
