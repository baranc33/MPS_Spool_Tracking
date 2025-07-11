using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.CircutSystem;
using Core.Concrete.ViewModels.SpoolAssembly;
using Core.Concrete.ViewModels.SpoolNavigator;
using Core.Concrete.ViewModels.SpoolWorkShopAssembly;
using Core.Concrete.ViewModels.SpoolWorkShopWelding;

namespace Core.Concrete.ViewModels.Spool
{
    public class SpoolViewModel : MpsStandartBaseEntity
    { // oluşturan değiştiren ve tarihleri içersindeki Navigasyon tablosundaolacaktır
        public DateTime CuttingTime { get; set; }
        public ushort No { get; set; }
        public string SpoolName { get; set; }// 30
        public byte spoolStatus { get; set; } // spool nerde 

        // Tersane = 0,  Asit = 1, Galvaniz = 2,  Boya=3
        public byte SendingLocation { get; set; }
        public ushort Diameter { get; set; }
        public float TotalKg { get; set; }

        public string Note { get; set; }

        public bool AssemblyOur { get; set; }
        public bool WorkPlaceOur { get; set; }








        public CircutSystemViewModel CircutSystem { get; set; }
        public ulong CircutSystemId { get; set; }


        public SpoolWorkShopAssemblyViewModel SpoolWorkShopAssembly { get; set; }
        public SpoolWorkShopWeldingViewModel SpoolWorkShopWelding { get; set; }
        public SpoolAssemblyViewModel SpoolAssembly { get; set; }
        public SpoolNavigatorViewModel SpoolNavigator { get; set; }




        
    }
}
