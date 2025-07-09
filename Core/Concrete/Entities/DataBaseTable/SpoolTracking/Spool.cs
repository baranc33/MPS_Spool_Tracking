
using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.SpoolTracking
{
    public class Spool:MpsTinyBaseEntity,IMpsEntity
    {
        // oluşturan değiştiren ve tarihleri içersindeki Navigasyon tablosundaolacaktır


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








        public CircutSystem CircutSystem { get; set; }
        public uint CircutSystemId { get; set; }


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
        public string WhereIsSpool()
        {

            switch (this.spoolStatus)
            {
                case 0: return "İmalat Bekleniyor";
                case 1: return "İmalat Başladı";
                case 2: return "Kaynak Bekleniyor";//İmalat Bitti / 
                case 3: return "Kaynakta Başladı";
                case 4: return "K.K. Bekleniyor";
                case 5: return "Sevk Bekleniyor";
                case 6: return "Sevk Edildi";
                case 7: return "Tersanede";
                case 8: return "Montaj Yapıldı";
                default:
                    return "Bilinmiyor";
            }

        }

    }
}
