using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class ProjectRepository : MpsGenericRepository<Project>, IProjectRepository
    {
        private readonly MpsDbContext _context;
        public ProjectRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }




}
