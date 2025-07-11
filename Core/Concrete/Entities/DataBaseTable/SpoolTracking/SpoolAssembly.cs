using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.Entities.DataBaseTable.UsersData;

namespace Core.Concrete.Entities.DataBaseTable.SpoolTracking
{
    public class SpoolAssembly :MpsStandartBaseEntity,IMpsEntity
    {

        public DateTime AssemblyTime { get; set; }
        public ulong AssemblyEmployeeId { get; set; }
        public Employee AssemblyEmployee { get; set; }
        public ushort AssemblyKg { get; set; }


        public SpoolNavigator SpoolNavigator { get; set; }



        public ulong AssemblyEngineerId { get; set; }
        public EmployeeUser AssemblyEngineer { get; set; }


        public ulong SpoolId { get; set; }
        public Spool Spool { get; set; }
    }
}
