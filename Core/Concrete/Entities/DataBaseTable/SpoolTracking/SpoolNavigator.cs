using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.SpoolTracking
{
    public class SpoolNavigator : MpsTinyBaseEntity, IMpsEntity
    {   // spoolla ilgili tüm tabloların ID'lerini tutar
        // bu sayede spoola ait tüm tablolara 1. elden erişim sağlanır
        
        public uint ProjectId { get; set; }
        public Project Project { get; set; }

       

        public uint CircutSystemId { get; set; }
        public CircutSystem CircutSystem { get; set; }

        public uint SpoolId { get; set; }
        public Spool Spool { get; set; }

        public uint SpoolAssemblyId { get; set; }
        public SpoolAssembly SpoolAssembly { get; set; }

        public uint SpoolWorkShopAssemblyId { get; set; }
        public SpoolWorkShopAssembly SpoolWorkShopAssembly { get; set; }

        public uint SpoolWorkShopWeldingId { get; set; }
        public SpoolWorkShopWelding SpoolWorkShopWelding { get; set; }


    }
}
