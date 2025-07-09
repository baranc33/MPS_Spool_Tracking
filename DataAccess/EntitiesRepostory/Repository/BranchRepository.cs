using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class BranchRepository : MpsGenericRepository<Branch>, IBranchRepository 
    {
        private readonly MpsDbContext _context;
        public BranchRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
