using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.CircutSystem;
using Core.Concrete.ViewModels.Project;
using Core.Concrete.ViewModels.Spool;
using Core.Concrete.ViewModels.SpoolAssembly;
using Core.Concrete.ViewModels.SpoolWorkShopAssembly;
using Core.Concrete.ViewModels.SpoolWorkShopWelding;

namespace Core.Concrete.ViewModels.SpoolNavigator
{
    public class SpoolNavigatorViewModel : MpsTinyBaseEntity
    {
        // spoolla ilgili tüm tabloların ID'lerini tutar
        // bu sayede spoola ait tüm tablolara 1. elden erişim sağlanır

        public ulong ProjectId { get; set; }
        public ProjectViewModel Project { get; set; }




        public ulong CircutSystemId { get; set; }
        public CircutSystemViewModel CircutSystem { get; set; }

        public ulong SpoolId { get; set; }
        public SpoolViewModel Spool { get; set; }

        public ulong SpoolAssemblyId { get; set; }
        public SpoolAssemblyViewModel SpoolAssembly { get; set; }

        public ulong SpoolWorkShopAssemblyId { get; set; }
        public SpoolWorkShopAssemblyViewModel SpoolWorkShopAssembly { get; set; }

        public ulong SpoolWorkShopWeldingId { get; set; }
        public SpoolWorkShopWeldingViewModel SpoolWorkShopWelding { get; set; }

    }
}
