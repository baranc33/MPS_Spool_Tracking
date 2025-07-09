using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class SpoolNavigatorRepository : MpsGenericRepository<SpoolNavigator >, ISpoolNavigatorRepository 
    {
        private readonly MpsDbContext _context;
        public SpoolNavigatorRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }




}
