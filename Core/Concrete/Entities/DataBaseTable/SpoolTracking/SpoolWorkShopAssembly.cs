using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;

namespace Core.Concrete.Entities.DataBaseTable.SpoolTracking
{
    public class SpoolWorkShopAssembly : MpsStandartBaseEntity, IMpsEntity
    {
        public ulong SpoolWorkShopAssemblyEmployeeId { get; set; }
        public Employee SpoolWorkShopAssemblyEmployee { get; set; }

        public DateTime AssemblyTime { get; set; }

        public ushort AssemblyKg { get; set; }

         
        public ulong SpoolId { get; set; }
        public Spool Spool { get; set; }

        public SpoolNavigator SpoolNavigator { get; set; }
         


    }
}
