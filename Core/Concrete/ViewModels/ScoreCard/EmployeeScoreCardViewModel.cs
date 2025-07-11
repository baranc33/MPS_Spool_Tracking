using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Employee;

namespace Core.Concrete.ViewModels.ScoreCard
{
    public class EmployeeScoreCardViewModel : MpsStandardBaseEntity
    {

        public DateTime DayDate { get; set; }
        public byte Status { get; set; }
        public ushort ShiftHour { get; set; }
        public ulong EmployeeId { get; set; }
        public EmployeeViewModel Employee { get; set; }


    }
}
