using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class SpoolWorkShopWeldingRepository : MpsGenericRepository<SpoolWorkShopWelding>, ISpoolWorkShopWeldingRepository
    {
        private readonly MpsDbContext _context;
        public SpoolWorkShopWeldingRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }


}
