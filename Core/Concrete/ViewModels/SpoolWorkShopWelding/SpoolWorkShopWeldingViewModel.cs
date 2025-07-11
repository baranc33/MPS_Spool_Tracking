using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Employee;
using Core.Concrete.ViewModels.Spool;
using Core.Concrete.ViewModels.SpoolNavigator;

namespace Core.Concrete.ViewModels.SpoolWorkShopWelding
{
    public class SpoolWorkShopWeldingViewModel : MpsStandardBaseEntity
    {


        public bool RootWeldingOn { get; set; } // Kök Kaynak Varmı
        public DateTime RootWeldingTime { get; set; }
        public ulong RootWeldingEmployeeId { get; set; }

        public EmployeeViewModel RootWeldingEmployee { get; set; }

        public DateTime CoverWeldingTime { get; set; }
        public ulong CoverWeldingEmployeeId { get; set; }
        public EmployeeViewModel CoverWeldingEmployee { get; set; }

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
        public SpoolViewModel Spool { get; set; }

        public SpoolNavigatorViewModel SpoolNavigator { get; set; }
    }
}
