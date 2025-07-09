using DataAccess.EntitiesRepostory.IRepository;
using DataAccess.EntitiesRepostory.Repository;

namespace DataAccess.EntitiesRepostory
{
    public class UnitOfWork : IUnitOfWork
    {


        private readonly MpsDbContext _context;

        public UnitOfWork(MpsDbContext context)
        {
            _context=context;
        }

        private StockRepository _StockRepository;
        private ScoreCardRepository _ScoreCardRepository;
        private EmployeeWorkRepository _EmployeeWorkRepository;
        private SpoolRepository _SpoolRepository;
        private BranchRepository _BranchRepository;
        private ProjectRepository _ProjectRepository;
        private MpsRoleRepository _MpsRoleRepository;
        private MpsUserRepository _MpsUserRepository;
        private ShipYardRepository _ShipYardRepository;
        private EmployeeRepository _EmployeeRepository;
        private CircutSystemRepository _CircutSystemRepository;
        private EmployeeUserRepository _EmployeeUserRepository;
        private EmployeeExitRepository _EmployeeExitRepository;
        private EmployeePointRepository _EmployeePointRepository;
        private SpoolWorkShopAssemblyRepository _SpoolWorkShopAssemblyRepository;
        private SpoolWorkShopWeldingRepository _SpoolWorkShopWeldingRepository;
        private SpoolAssemblyRepository _SpoolAssemblyRepository;
        private SpoolNavigatorRepository _SpoolNavigatorRepository;
        private EmployeeProjectRepository _EmployeeProjectRepository;
        private OtomaticSystemCodeRepository _OtomaticSystemCodeRepository;


        public IStockRepository IStockRepository => _StockRepository ?? new StockRepository(_context);
        public ISpoolRepository SpoolRepository => _SpoolRepository?? new SpoolRepository(_context);
        public IBranchRepository BranchRepository => _BranchRepository ?? new BranchRepository(_context);
        public IProjectRepository ProjectRepository => _ProjectRepository ?? new ProjectRepository(_context);
        public IMpsRoleRepository MpsRoleRepository => _MpsRoleRepository ?? new MpsRoleRepository(_context);
        public IMpsUserRepository MpsUserRepository => _MpsUserRepository ?? new MpsUserRepository(_context);
        public IShipYardRepository ShipYardRepository => _ShipYardRepository ?? new ShipYardRepository(_context);
        public IEmployeeRepository EmployeeRepository => _EmployeeRepository ?? new EmployeeRepository(_context);
        public IScoreCardRepository IScoreCardRepository => _ScoreCardRepository ?? new ScoreCardRepository(_context);
        public IEmployeeWorkRepository IEmployeeWorkRepository => _EmployeeWorkRepository ?? new EmployeeWorkRepository(_context);
        public ICircutSystemRepository CircutSystemRepository => _CircutSystemRepository ?? new CircutSystemRepository(_context);
        public IEmployeeUserRepository EmployeeUserRepository => _EmployeeUserRepository ?? new EmployeeUserRepository(_context);
        public IEmployeeExitRepository EmployeeExitRepository => _EmployeeExitRepository ?? new EmployeeExitRepository(_context);
        public IEmployeePointRepository EmployeePointRepository => _EmployeePointRepository ?? new EmployeePointRepository(_context);
        public ISpoolAssemblyRepository SpoolAssemblyRepository => _SpoolAssemblyRepository ?? new SpoolAssemblyRepository(_context);
        public ISpoolNavigatorRepository SpoolNavigatorRepository => _SpoolNavigatorRepository ?? new SpoolNavigatorRepository(_context);
        public IEmployeeProjectRepository EmployeeProjectRepository => _EmployeeProjectRepository ?? new EmployeeProjectRepository(_context);
        public IOtomaticSystemCodeRepository OtomaticSystemCodeRepository => _OtomaticSystemCodeRepository ?? new OtomaticSystemCodeRepository(_context);
        public ISpoolWorkShopWeldingRepository SpoolWorkShopWeldingRepository => _SpoolWorkShopWeldingRepository ?? new SpoolWorkShopWeldingRepository(_context);
        public ISpoolWorkShopAssemblyRepository SpoolWorkShopAssemblyRepository => _SpoolWorkShopAssemblyRepository ?? new SpoolWorkShopAssemblyRepository(_context);


        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
