using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.Entities.DataBaseTable.UsersData;

namespace Core.Concrete.Entities.DataBaseTable.EmployeeData
{
    public class EmployeeProject : MpsStandardBaseEntity, IMpsEntity
    {    // Hangi Personel
        public ulong EmployeeId { get; set; }
        public Employee Employee { get; set; }
        // projedeki pozisyonu
        public ulong BranchId { get; set; }
        public Branch Branch { get; set; }


        public ulong EmployeeWorkId { get; set; }
        public EmployeeWork EmployeeWork { get; set; }//=> Personelin Yaptığı iş
        // Hangi proje

        public ulong ProjectId { get; set; }
        public Project Project { get; set; }
        // projede çalıştığı tarih aralığını bulmak için.
        public DateTime StartDate { get; set; } = DateTime.Now;


        // çalıştığı projede  yöneticisi puanı verecek kişi
        public ulong ManagerUserId { get; set; }
        public EmployeeUser  ManagerUser { get; set; }
    }
}
