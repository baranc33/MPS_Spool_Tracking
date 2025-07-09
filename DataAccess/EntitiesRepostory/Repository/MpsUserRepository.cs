using Core.Concrete.Entities.DataBaseTable.UsersData;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class MpsUserRepository : MpsGenericRepository<MpsUser>, IMpsUserRepository 
    {
        private readonly MpsDbContext _context;
        public MpsUserRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }




}
