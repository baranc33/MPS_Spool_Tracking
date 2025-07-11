using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.EmployeeData
{
    public class EmployeeScoreCard : MpsStandardBaseEntity, IMpsEntity
    {
        public DateTime DayDate { get; set; }
        public byte Status { get; set; }
        public ushort ShiftHour { get; set; }
        public ulong EmployeeId{ get; set; }
        public Employee Employee{ get; set; }
    }
}
