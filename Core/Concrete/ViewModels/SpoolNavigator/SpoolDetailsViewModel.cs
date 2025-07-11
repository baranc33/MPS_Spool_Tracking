using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.ViewModels.SpoolNavigator
{
    public class SpoolDetailsViewModel
    {
        public SpoolDetailsViewModel()
        {
        }
        public string ProjectManager { get; set; }
        public string ProjectManagerLinkedin { get; set; }
        public string ProjectManagerPicture { get; set; }


        public ulong Id { get; set; }
        public bool IsDelete { get; set; }//=> Nesnenin Silinip Silinmediğini Belirten Özellik
        public bool IsWork { get; set; } //=> Nesnenin Kullanılır olup Olmadığını Belirten özellik.   
        public bool ReallyDeleted { get; set; } = true;// hiç bir şekilde  silinmesini istemediğimiz verilerde false yaparız
        public DateTime ModifiedTime { get; set; }  //=>  En Son Güncellenme Tarihi.
        public string ModifiedUserName { get; set; } //=> En Son Güncelliyen Kişi.
        public uint? LastBackUpId { get; set; } //=> Son Yapılan Değişikliğin Kaydını Tutan Id.
        public DateTime CreateDate { get; set; }  //==> Nesnenin ilk Oluşturulduğu Tarih.
        public string ShipYardName { get; set; }
        public string ProjectName { get; set; }
        public ushort No { get; set; }
        public string SystemName { get; set; }
        public string SpoolName { get; set; }// 30
        public byte spoolStatus { get; set; } // spool nerde 
        public byte SendingLocation { get; set; }
        public ushort Diameter { get; set; }
        public float TotalKg { get; set; }
        public string Note { get; set; }
        public bool AssemblyOur { get; set; }
        public bool WorkPlaceOur { get; set; }
        /// Montaj bilgileri
        public bool AssemblyStatu { get; set; }
        public DateTime AssemblyTime { get; set; } //  Montaj Zamanı
        public string AssemblyEmployeeFullName { get; set; } // Montaj yapanın Adı ve Soyadı
        public string AssemblyEmployeeWorkShipyardName{ get; set; }//=> Montaj yapanın Çalıştığı tersane
        public string AssemblyEmployeePhone{ get; set; }//=> Montaj yapanın Telefonu
        public string AssemblyEnginieerName { get; set; }//=> Montaj Kontrol yapan Mühendisin adı
        public ushort AssemblyKg { get; set; }//=> Montaj Kg
        /// imalat bilgileri
        public bool SpoolWorkShopAssemblyStatu { get; set; } // ön imalat durumu
        public DateTime SpoolWorkShopAssemblyTime { get; set; }// ön imalat zamanı
        public string SpoolWorkShopAssemblyEmployeeFullName { get; set; }// ön imalat yapanın Adı ve Soyadı
        public string SpoolWorkShopAssemblyEmployeePhone { get; set; }//=> ön imalat  yapanın Telefonu
        public ushort SpoolWorkShopAssemblyKg { get; set; } // ön imalat kg
        /// Kaynak bilgileri
        public bool WeldingStatu { get; set; }//  Kaynak Durumu
        public bool RootWeldingOn { get; set; } // Kök Kaynak Varmı
        public byte WeldingDiameter { get; set; }// Personel Kaynak inçi 
        public DateTime RootWeldingTime { get; set; } // Kök Kaynak Zamanı
        public DateTime CoverWeldingTime { get; set; } // kapak Kaynak Zamanı
        public string RootWeldingEmployeeFullName { get; set; } // Kök Kaynak yapanın Adı ve Soyadı
        public string CoverWeldingEmployeeFullName { get; set; } //kapak Kapak Kaynak yapanın Adı ve Soyadı
        public string RootWeldingEmployeePhone { get; set; }//=> Kök    Kapak Kaynak  yapanın Telefonu
        public string CoverWeldingEmployeePhone { get; set; }//=> kapak Kapak Kaynak yapanın Telefonu
        /// Kalite bilgileri
        public DateTime QualityTime { get; set; }// kaliteye Daveti Zamanı
        public DateTime QualityCheckTime { get; set; }// kaliteye Onay Red Zamanı
        public bool QualityStatu { get; set; }// Kalite Durumu
        public bool PassedQualityControl { get; set; }// kaliteye Kontrolden Geçtimi
        public string invitationToQuality { get; set; }// kaliteye davet eden
        /// Sevk bilgileri
        public DateTime SendTime { get; set; } // sevk zamanı
        public bool Shipped { get; set; }// sevk edildimi
        public ushort ShippingKg { get; set; } // sevk ağırlığı  
        
    }
}
