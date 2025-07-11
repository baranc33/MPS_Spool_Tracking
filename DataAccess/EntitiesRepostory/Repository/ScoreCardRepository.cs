using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class ScoreCardRepository : MpsGenericRepository<EmployeeScoreCard>, IScoreCardRepository
    {
        private readonly MpsDbContext _context;
        public ScoreCardRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
