using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;

namespace Core.Concrete.Entities.DataBaseTable.SpoolTracking
{
    public class SpoolAssembly :MpsTinyBaseEntity,IMpsEntity
    {
        public DateTime AssemblyTime { get; set; }
        public uint AssemblyEmployeeId { get; set; }
        public Employee AssemblyEmployee { get; set; }
        public ushort AssemblyKg { get; set; }


        public SpoolNavigator SpoolNavigator { get; set; }






        public uint SpoolId { get; set; }
        public Spool Spool { get; set; }
    }
}
