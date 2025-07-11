using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Employee;
using Core.Concrete.ViewModels.Spool;
using Core.Concrete.ViewModels.SpoolNavigator;

namespace Core.Concrete.ViewModels.SpoolWorkShopAssembly
{
    public class SpoolWorkShopAssemblyViewModel : MpsStandardBaseEntity
    {


        public DateTime AssemblyTime { get; set; }

        public ulong AssemblyEmployeeId { get; set; }
        public EmployeeViewModel AssemblyEmployee { get; set; }
        public ushort AssemblyKg { get; set; }





        public ulong SpoolId { get; set; }
        public SpoolViewModel Spool { get; set; }

        public SpoolNavigatorViewModel SpoolNavigator { get; set; }

    }
}
