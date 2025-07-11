using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.ViewModels.SpoolNavigator
{
    public class SpoolWorkShopWeldingDetailsViewModel : MpsStandardBaseEntity// spoolun bilgilerini tutcak base entityde
    {

        public string ShipYardName { get; set; }
        public string ProjectName { get; set; }
        public ushort No { get; set; }
        public string SystemName { get; set; }
        public string SpoolName { get; set; }// 30
        public byte spoolStatus { get; set; } // spool nerde 

        // Tersane = 0,  Asit = 1, Galvaniz = 2,  Boya=3
        public byte SendingLocation { get; set; }
        public ushort Diameter { get; set; }
        public float TotalKg { get; set; }

        public string Note { get; set; }

        public bool AssemblyOur { get; set; }
        public bool WorkPlaceOur { get; set; }



        public bool SpoolWorkShopAssemblyStatu { get; set; } // ön imalat durumu
        public DateTime SpoolWorkShopAssemblyTime { get; set; }// ön imalat zamanı
        public string SpoolWorkShopAssemblyEmployeeFullName { get; set; }// ön imalat yapanın Adı ve Soyadı
        public string SpoolWorkShopAssemblyEmployeePhone { get; set; }//=> ön imalat  yapanın Telefonu
        public ushort SpoolWorkShopAssemblyKg { get; set; } // ön imalat kg






        public bool WeldingStatu { get; set; }//  Kaynak Durumu
        public DateTime RootWeldingTime { get; set; } // Kök Kaynak Zamanı
        public DateTime CoverWeldingTime { get; set; } // kapak Kaynak Zamanı
        public string RootWeldingEmployeeFullName { get; set; } // Kök Kaynak yapanın Adı ve Soyadı
        public string CoverWeldingEmployeeFullName { get; set; } //kapak Kapak Kaynak yapanın Adı ve Soyadı
        public string RootWeldingEmployeePhone { get; set; }//=> Kök    Kapak Kaynak  yapanın Telefonu
        public string CoverWeldingEmployeePhone { get; set; }//=> kapak Kapak Kaynak yapanın Telefonu



        public DateTime QualityTime { get; set; }// kaliteye Daveti Zamanı
        public DateTime QualityCheckTime { get; set; }// kaliteye Onay Red Zamanı
        public bool QualityStatu { get; set; }// Kalite Durumu
        public bool PassedQualityControl { get; set; }// kaliteye Kontrolden Geçtimi
        public string invitationToQuality { get; set; }// kaliteye davet eden

        public DateTime SendTime { get; set; } // sevk zamanı
        public bool Shipped { get; set; }// sevk edildimi

        public ushort ShippingKg { get; set; } // sevk ağırlığı  


        public bool RootWeldingOn { get; set; } // Kök Kaynak Varmı
        public byte WeldingDiameter { get; set; }




    }
}
