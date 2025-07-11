using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.ViewModels.Employee
{
    public class EmployeeExitViewModel : MpsStandardBaseEntity
    {
        // Hangi Personel
        public ulong EmployeeId { get; set; }
        public EmployeeViewModel Employee { get; set; }

        // çalıştığı süreçte genel Puan Ortalaması
        public byte TeamWorkAveragePoint { get; set; }
        public byte JabTrackingAveragePoint { get; set; }
        public byte ContinuityAveragePoint { get; set; }
        public byte AveragePoint { get; set; }


        // çalıştığı tarih aralığı
        public DateTime WorkStartDate { get; set; }
        public DateTime WorkFinishDate { get; set; }


        public string ExitNote { get; set; }

        // çalışmış olduğu yerlerin string olarak girileceği yer
        public string EmployeeProjects { get; set; }
        //public ICollection<EmployeeProject> EmployeeProjects { get; set; }


    }
}
