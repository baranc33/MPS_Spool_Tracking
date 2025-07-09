using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class EmployeePointRepository : MpsGenericRepository<EmployeePoint >, IEmployeePointRepository 
    { 
        private readonly MpsDbContext _context;
        public EmployeePointRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }




}
