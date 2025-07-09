using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class EmployeeRepository : MpsGenericRepository<Employee >, IEmployeeRepository
    { 
        private readonly MpsDbContext _context;
        public EmployeeRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }




}
