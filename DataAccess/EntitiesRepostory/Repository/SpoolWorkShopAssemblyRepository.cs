using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class SpoolWorkShopAssemblyRepository : MpsGenericRepository<SpoolWorkShopAssembly >, ISpoolWorkShopAssemblyRepository
    {
        private readonly MpsDbContext _context;
        public SpoolWorkShopAssemblyRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }


}
