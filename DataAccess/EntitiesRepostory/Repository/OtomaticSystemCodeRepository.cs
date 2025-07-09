using Core.Concrete.Entities.DataBaseTable.SingleEntity;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class OtomaticSystemCodeRepository : MpsGenericRepository<OtomaticSystemCode>, IOtomaticSystemCodeRepository 
    {
        private readonly MpsDbContext _context;
        public OtomaticSystemCodeRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }




}
