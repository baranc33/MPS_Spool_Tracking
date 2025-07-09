using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class ShipYardRepository : MpsGenericRepository<ShipYard>, IShipYardRepository
    {
        private readonly MpsDbContext _context;
        public ShipYardRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }




}
