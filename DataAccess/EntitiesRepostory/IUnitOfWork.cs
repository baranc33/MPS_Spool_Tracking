using DataAccess.EntitiesRepostory.IRepository;

namespace DataAccess.EntitiesRepostory
{
    public interface IUnitOfWork : IAsyncDisposable
    {


        IEmployeeWorkRepository IEmployeeWorkRepository { get; }
        IStockRepository IStockRepository { get; }
        IScoreCardRepository IScoreCardRepository { get; }
        ISpoolRepository SpoolRepository { get; }
        IBranchRepository BranchRepository { get; }
        IProjectRepository ProjectRepository { get; }
        IMpsRoleRepository MpsRoleRepository { get; }
        IMpsUserRepository MpsUserRepository { get; }
        IShipYardRepository ShipYardRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }
        ICircutSystemRepository CircutSystemRepository { get; }
        IEmployeeUserRepository EmployeeUserRepository { get; }
        IEmployeeExitRepository EmployeeExitRepository { get; }
        IEmployeePointRepository EmployeePointRepository { get; }
        ISpoolWorkShopWeldingRepository SpoolWorkShopWeldingRepository { get; }
        ISpoolWorkShopAssemblyRepository SpoolWorkShopAssemblyRepository { get; }
        ISpoolAssemblyRepository SpoolAssemblyRepository { get; }
        ISpoolNavigatorRepository SpoolNavigatorRepository { get; }
        IEmployeeProjectRepository EmployeeProjectRepository { get; }
        IOtomaticSystemCodeRepository OtomaticSystemCodeRepository { get; }



        Task<int> SaveAsync();
    }

}
