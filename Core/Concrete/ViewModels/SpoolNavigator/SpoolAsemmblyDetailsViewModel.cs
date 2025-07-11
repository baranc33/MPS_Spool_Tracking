using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Employee;

namespace Core.Concrete.ViewModels.SpoolNavigator
{
    public class SpoolAsemmblyDetailsViewModel : MpsStandartBaseEntity// spoolun bilgilerini tutcak base entityde
    {

       
        public string ShipYardName { get; set; }
        public string ProjectName { get; set; }
        public ushort No { get; set; }
        public string SystemName { get; set; }
        public string SpoolName { get; set; }// 30 
         
        public ushort Diameter { get; set; }
        public float TotalKg { get; set; }

        public string Note { get; set; }

 


  
        public bool AssemblyStatu { get; set; }
        public DateTime AssemblyTime { get; set; } //  Montaj Zamanı
        public string AssemblyEmployeeFullName { get; set; } // Montaj yapanın Adı ve Soyadı
        public string AssemblyEmployeeWorkShipyardName{ get; set; }//=> Montaj yapanın Çalıştığı tersane
        public string AssemblyEmployeePhone{ get; set; }//=> Montaj yapanın Telefonu
        public string AssemblyEnginieerName { get; set; }//=> Montaj Kontrol yapan Mühendisin adı
        public ushort AssemblyKg { get; set; }//=> Montaj Kg


        public DateTime SendTime { get; set; } // sevk zamanı
        public bool Shipped { get; set; }// sevk edildimi
         
         




    }
}
