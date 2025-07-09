using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class EmployeeWorkRepository : MpsGenericRepository<EmployeeWork>, IEmployeeWorkRepository
    {
        private readonly MpsDbContext _context;
        public EmployeeWorkRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }

}
