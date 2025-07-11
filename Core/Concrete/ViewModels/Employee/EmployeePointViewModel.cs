using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.ViewModels.Employee
{
    public class EmployeePointViewModel : MpsStandardBaseEntity
    {// Hangi Personel
        public ulong EmployeeId { get; set; }
        public EmployeeViewModel Employee { get; set; }

        public byte TeamWorkPoint { get; set; }
        public byte JabTrackingPoint { get; set; }
        public byte ContinuityPoint { get; set; }

        public byte AveragePoint { get; set; }

        // puanın verildi tarih aralığı
        public DateTime GiveDateStart { get; set; }
        public DateTime GiveDateFinish { get; set; }


        // puanı veren kişi Oluşturan kişi
        public string UserNameGivePoint { get; set; }
        public string UserId { get; set; }
    }
}
