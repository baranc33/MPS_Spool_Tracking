using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class SpoolRepository : MpsGenericRepository<Spool>, ISpoolRepository
    {
        private readonly MpsDbContext _context;
        public SpoolRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }
}


