using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.Entities.DataBaseTable.UsersData;

namespace Core.Concrete.Entities.DataBaseTable.SpoolTracking
{
    public class SpoolNavigator : MpsTinyBaseEntity, IMpsEntity
    {
       


        // spoolla ilgili tüm tabloların ID'lerini tutar
        // bu sayede spoola ait tüm tablolara 1. elden erişim sağlanır

        public ulong ProjectId { get; set; }
        public Project Project { get; set; }

        ///***** Eklenecek *******//////////
        public ulong ProjectManagerId { get; set; }
        public EmployeeUser ProjectManager { get; set; }
        public ulong ProjectManagerEmployeeId { get; set; }
        public Employee ProjectManagerEmployee { get; set; }






        public ulong CircutSystemId { get; set; }
        public CircutSystem CircutSystem { get; set; }

        public ulong SpoolId { get; set; }
        public Spool Spool { get; set; }

        public ulong SpoolAssemblyId { get; set; }
        public SpoolAssembly SpoolAssembly { get; set; }


        public ulong SpoolWorkShopAssemblyId { get; set; }
        public SpoolWorkShopAssembly SpoolWorkShopAssembly { get; set; }

        public ulong SpoolWorkShopWeldingId { get; set; }
        public SpoolWorkShopWelding SpoolWorkShopWelding { get; set; }


    }
}
