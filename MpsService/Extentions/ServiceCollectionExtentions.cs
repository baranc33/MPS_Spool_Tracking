using DataAccess.EntitiesRepostory;
using DataAccess.EntitiesRepostory.IRepository;
using DataAccess.EntitiesRepostory.Repository;
using Microsoft.Extensions.DependencyInjection;
using MpsService.EntityService;
using MpsService.EntityService.IService;
using MpsService.EntityService.Service;

namespace MpsService.Extentions
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<MpsDbContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
            serviceCollection.AddScoped(typeof(IMpsGenericRepository<>), typeof(MpsGenericRepository<>));




            serviceCollection.AddScoped<IStockRepository, StockRepository>();
            serviceCollection.AddScoped<IStockService, StockService>();

            serviceCollection.AddScoped<IScoreCardRepository, ScoreCardRepository>();
            serviceCollection.AddScoped<IScoreCardService, ScoreCardService>();





            serviceCollection.AddScoped<IEmployeeWorkRepository, EmployeeWorkRepository>();
            serviceCollection.AddScoped<IEmployeeWorkService, EmployeeWorkService>();




            serviceCollection.AddScoped<ISpoolRepository, SpoolRepository>();
            serviceCollection.AddScoped<ISpoolService, SpoolService>();

            serviceCollection.AddScoped<IBranchRepository, BranchRepository>();
            serviceCollection.AddScoped<IBranchService, BranchService>();

            serviceCollection.AddScoped<IProjectRepository, ProjectRepository>();
            serviceCollection.AddScoped<IProjectService, ProjectService>();

            serviceCollection.AddScoped<IMpsRoleRepository, MpsRoleRepository>();
            serviceCollection.AddScoped<IMpsRoleService, MpsRoleService>();

            serviceCollection.AddScoped<IMpsUserRepository, MpsUserRepository>();
            serviceCollection.AddScoped<IMpsUserService, MpsUserService>();

            serviceCollection.AddScoped<IShipYardRepository, ShipYardRepository>();
            serviceCollection.AddScoped<IShipYardService, ShipYardService>();

            serviceCollection.AddScoped<IEmployeeRepository, EmployeeRepository>();
            serviceCollection.AddScoped<IEmployeeService, EmployeeService>();

            serviceCollection.AddScoped<ICircutSystemRepository, CircutSystemRepository>();
            serviceCollection.AddScoped<ICircutSystemService, CircutSystemService>();

            serviceCollection.AddScoped<IEmployeeUserRepository, EmployeeUserRepository>();
            serviceCollection.AddScoped<IEmployeeUserService, EmployeeUserService>();

            serviceCollection.AddScoped<IEmployeeExitRepository, EmployeeExitRepository>();
            serviceCollection.AddScoped<IEmployeeExitService, EmployeeExitService>();


            serviceCollection.AddScoped<IEmployeePointRepository, EmployeePointRepository>();
            serviceCollection.AddScoped<IEmployeePointService, EmployeePointService>();


            serviceCollection.AddScoped<ISpoolWorkShopWeldingRepository, SpoolWorkShopWeldingRepository>();
            serviceCollection.AddScoped<ISpoolWorkShopWeldingService, SpoolWorkShopWeldingService>();


            serviceCollection.AddScoped<ISpoolWorkShopAssemblyRepository, SpoolWorkShopAssemblyRepository>();
            serviceCollection.AddScoped<ISpoolWorkShopAssemblyService, SpoolWorkShopAssemblyService>();

            serviceCollection.AddScoped<ISpoolAssemblyRepository, SpoolAssemblyRepository>();
            serviceCollection.AddScoped<ISpoolAssemblyService, SpoolAssemblyService>();


            serviceCollection.AddScoped<ISpoolNavigatorRepository, SpoolNavigatorRepository>();
            serviceCollection.AddScoped<ISpoolNavigatorService, SpoolNavigatorService>();


            serviceCollection.AddScoped<IEmployeeProjectRepository, EmployeeProjectRepository>();
            serviceCollection.AddScoped<IEmployeeProjectService, EmployeeProjectService>();

            serviceCollection.AddScoped<IOtomaticSystemCodeRepository, OtomaticSystemCodeRepository>();
            serviceCollection.AddScoped<IOtomaticSystemCodeService, OtomaticSystemCodeService>();




            return serviceCollection;
        }
    }
}
