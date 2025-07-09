using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class EmployeeProjectRepository : MpsGenericRepository<EmployeeProject >, IEmployeeProjectRepository
    {
        private readonly MpsDbContext _context;
        public EmployeeProjectRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }




}
