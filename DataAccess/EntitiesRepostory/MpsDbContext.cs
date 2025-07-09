using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.Entities.DataBaseTable.SingleEntity;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.Entities.DataBaseTable.UsersData;
using DataAccess.Mapping;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntitiesRepostory
{
    public class MpsDbContext : IdentityDbContext<MpsUser, MpsRole, string>
    {

        public MpsDbContext(DbContextOptions<MpsDbContext> options) : base(options)
        {
        }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<ScoreCard> ScoreCard { get; set; }
        public DbSet<Spool> Spools { get; set; }
        public DbSet<EmployeeWork> EmployeeWork { get; set; }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ShipYard> ShipYards { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<CircutSystem> CircutSystems { get; set; }
        public DbSet<EmployeeUser> EmployeeUsers { get; set; }
        public DbSet<EmployeeExit> EmployeeExits { get; set; }
        public DbSet<EmployeePoint> EmployeePoints { get; set; }
        public DbSet<SpoolWorkShopAssembly> SpoolWorkShopAssembly { get; set; }
        public DbSet<SpoolWorkShopWelding> SpoolWorkShopWelding { get; set; }
        public DbSet<SpoolAssembly> SpoolAssemblies { get; set; }
        public DbSet<SpoolNavigator> SpoolNavigators { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public DbSet<OtomaticSystemCode> OtomaticSystemCodes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ScoreCardMap());
            modelBuilder.ApplyConfiguration(new StockMap());
            modelBuilder.ApplyConfiguration(new BranchMap());
            modelBuilder.ApplyConfiguration(new CircutSystemMap());
            modelBuilder.ApplyConfiguration(new EmployeeExitMap());
            modelBuilder.ApplyConfiguration(new EmployeeMap());
            modelBuilder.ApplyConfiguration(new EmployeePointMap());
            modelBuilder.ApplyConfiguration(new EmployeeProjectMap());
            modelBuilder.ApplyConfiguration(new EmployeeUserMap());
            modelBuilder.ApplyConfiguration(new MpsRoleMap());
            modelBuilder.ApplyConfiguration(new MpsUserMap());
            modelBuilder.ApplyConfiguration(new OtomaticSystemCodeMap());
            modelBuilder.ApplyConfiguration(new ProjectMap());
            modelBuilder.ApplyConfiguration(new ShipYardMap());
            modelBuilder.ApplyConfiguration(new SpoolAssemblyMap());
            modelBuilder.ApplyConfiguration(new SpoolMap());
            modelBuilder.ApplyConfiguration(new SpoolNavigatorMap());



            modelBuilder.ApplyConfiguration(new SpoolWorkShopAssemblyMap());
            modelBuilder.ApplyConfiguration(new EmployeeWorkMap());
            modelBuilder.ApplyConfiguration(new SpoolWorkShopWeldingMap());
        
        }
    }
}
