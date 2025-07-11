using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Helper.SpoolMethod;

namespace Core.Concrete.Entities.DataBaseTable.SpoolTracking
{
    public class Spool : MpsStandartBaseEntity, IMpsEntity
    {



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








        public ulong CircutSystemId { get; set; }
        public CircutSystem CircutSystem { get; set; }


        public SpoolWorkShopAssembly SpoolWorkShopAssembly { get; set; }
        public SpoolWorkShopWelding SpoolWorkShopWelding { get; set; }
        public SpoolAssembly SpoolAssembly { get; set; }
        public SpoolNavigator SpoolNavigator { get; set; }




        // ön imalat bekliyor 0
        // ön imalat başladı 1 
        // ön imalat bitti 2
        // kaynak  başladı 3
        // kaynak kök bitti 4
        // kaynak kapak başladı 5
        // kaynak bitti 6 
        // Kalite Kontrol Yapıldı 7 
        // sevk bekliyor 8
        // sevk edildi  9
        public string WhereIsSpool(byte spoolStatus)
        {

            return SpoolMethods.WhereIsSpool(spoolStatus);
        }

    }
}
