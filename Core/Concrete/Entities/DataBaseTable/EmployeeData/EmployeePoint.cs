using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.EmployeeData
{
    public class EmployeePoint:MpsTinyBaseEntity,IMpsEntity
    {
        // Hangi Personel
        public uint EmployeeId { get; set; }
        public Employee Employee { get; set; }


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
