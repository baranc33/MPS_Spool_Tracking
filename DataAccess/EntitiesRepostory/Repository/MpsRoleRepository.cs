using Core.Concrete.Entities.DataBaseTable.UsersData;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class MpsRoleRepository : MpsGenericRepository<MpsRole>, IMpsRoleRepository 
    {
        private readonly MpsDbContext _context;
        public MpsRoleRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }




}
