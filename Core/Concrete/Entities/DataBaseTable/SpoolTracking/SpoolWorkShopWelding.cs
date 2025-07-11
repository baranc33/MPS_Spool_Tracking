using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;

namespace Core.Concrete.Entities.DataBaseTable.SpoolTracking
{
    public class SpoolWorkShopWelding : MpsStandardBaseEntity, IMpsEntity
    {

        public bool RootWeldingOn { get; set; } // Kök Kaynak Varmı
        public DateTime RootWeldingTime { get; set; }

        public ulong RootWeldingEmployeeId { get; set; }
        public Employee RootWeldingEmployee { get; set; }
        public DateTime CoverWeldingTime { get; set; }
        public ulong CoverWeldingEmployeeId { get; set; }
        public Employee CoverWeldingEmployee { get; set; }

        public byte WeldingDiameter { get; set; }

        public DateTime QualityDate { get; set; }// kaliteye Daveti Zamanı
        public DateTime QualityCheckTime { get; set; }// kaliteye Onay Red Zamanı
        public bool QualityStatu { get; set; }// Kalite Durumu
        public bool PassedQualityControl { get; set; }// kaliteye Kontrolden Geçtimi
        public string invitationToQuality { get; set; }// kaliteye davet eden

        public DateTime SendTime { get; set; } // sevk zamanı
        public bool Shipped { get; set; }// sevk edildimi

        public ushort ShippingKg { get; set; } // sevk ağırlığı  


        public ulong SpoolId { get; set; }
        public Spool Spool { get; set; }

        public SpoolNavigator SpoolNavigator { get; set; }


    }
}
