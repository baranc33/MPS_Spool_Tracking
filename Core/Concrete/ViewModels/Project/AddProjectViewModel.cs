using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.ViewModels.Project
{
    public class AddProjectViewModel : MpsStandardBaseEntity
    {

        // Associated shipyard
        public ulong ShipYardId { get; set; }
 

        public DateTime ProjectStartDate { get; set; } = DateTime.Now;
   
        // proje adı
        public string ProjectName { get; set; } = "1";

        // Proje sorumlusu
        public ulong ProjectManagerId { get; set; }


        // toplam spool sayısı üstünden % hesaplaması için ayrılmış bi alan
        public ushort TotalSpoolCount { get; set; }

    }














}
