using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class SpoolAssemblyRepository : MpsGenericRepository<SpoolAssembly >, ISpoolAssemblyRepository 
    { 
        private readonly MpsDbContext _context;
        public SpoolAssemblyRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }




}
