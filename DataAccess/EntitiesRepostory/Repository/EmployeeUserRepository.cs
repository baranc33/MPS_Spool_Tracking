using Core.Concrete.Entities.DataBaseTable.UsersData;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class EmployeeUserRepository : MpsGenericRepository<EmployeeUser >, IEmployeeUserRepository 
    {
        private readonly MpsDbContext _context;
        public EmployeeUserRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }




}
