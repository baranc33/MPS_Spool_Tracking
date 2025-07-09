using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class CircutSystemRepository : MpsGenericRepository<CircutSystem >, ICircutSystemRepository 
    {
        private readonly MpsDbContext _context;
        public CircutSystemRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }





}
