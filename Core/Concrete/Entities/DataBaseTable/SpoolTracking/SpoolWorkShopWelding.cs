using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;

namespace Core.Concrete.Entities.DataBaseTable.SpoolTracking
{
    public class SpoolWorkShopWelding : MpsTinyBaseEntity, IMpsEntity
    {

    

        public DateTime WeldingTime { get; set; }

        public uint WeldingEmployeeId { get; set; }
        public Employee WeldingEmployee { get; set; }


        public DateTime QualityTime { get; set; }

        // kalite daveti çeken
        // kalite geçenler 
        // kalite tarihi 
        public DateTime SendTime { get; set; }

        // sevk tarihi
        // sevk durumu
        // sevk ağırlığı 


        public uint SpoolId { get; set; }
        public Spool Spool { get; set; }

        public SpoolNavigator SpoolNavigator { get; set; }


    }
}
