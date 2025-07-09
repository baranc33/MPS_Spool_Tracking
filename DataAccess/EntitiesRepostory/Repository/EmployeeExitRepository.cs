using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class EmployeeExitRepository : MpsGenericRepository<EmployeeExit>, IEmployeeExitRepository
    { 
        private readonly MpsDbContext _context;
        public EmployeeExitRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }




}
