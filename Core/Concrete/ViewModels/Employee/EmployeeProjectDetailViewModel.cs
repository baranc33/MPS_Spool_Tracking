using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Brach;
using Core.Concrete.ViewModels.Project;

namespace Core.Concrete.ViewModels.Employee
{
    public class EmployeeProjectDetailViewModel : MpsStandartBaseEntity
    {
        // Hangi Personel
        public ulong EmployeeId { get; set; }
        public EmployeeViewModel Employee { get; set; }
        // projedeki pozisyonu
        public ulong BranchId { get; set; }
        public BranchViewModel Branch { get; set; }


        public ulong EmployeeWorkId { get; set; }
        public EmployeeWorkViewModel EmployeeWork { get; set; }//=> Personelin Yaptığı iş
        // Hangi proje

        public ulong ProjectId { get; set; }
        public ProjectViewModel Project { get; set; }
        // projede çalıştığı tarih aralığını bulmak için.
        public DateTime StartDate { get; set; } = DateTime.Now;


        // çalıştığı projede  yöneticisi puanı verecek kişi
        public ulong ManagerUserId { get; set; }
        public EmployeeUserViewModel ManagerUser { get; set; }
    }
}
