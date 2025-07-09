using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.EmployeeData
{
    public class ScoreCard : MpsStandartBaseEntity, IMpsEntity
    {
        public DateTime Day { get; set; }
        public byte Status { get; set; }
        public ushort ShiftHour { get; set; }
        public uint EmployeeId{ get; set; }
        public Employee Employee{ get; set; }
    }
}
