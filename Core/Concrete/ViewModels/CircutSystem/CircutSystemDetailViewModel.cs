using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Spool;

namespace Core.Concrete.ViewModels.CircutSystem
{
    public class CircutSystemDetailViewModel : MpsStandardBaseEntity
    {
        public DateTime CircutSystemStartTime { get; set; }
        public DateTime CircutSystemFinishTime { get; set; }
        public string ShipYardName { get; set; }
        public string ProjectName { get; set; }
        public string SystemName { get; set; }

        public ushort SystemTotalSpoolCount { get; set; }
        public uint ProjectTotalSpoolCount { get; set; }

        public ulong ProjectId { get; set; }
        public DateTime ProjectStartTime { get; set; } = DateTime.Now;
        public DateTime? ProjectFinishTime { get; set; } = null; // proje bitiş tarihi opsiyonel olabilir. çünkü bitmeyen projeler var.
        public ICollection<SpoolViewModel> Spools { get; set; } = new List<SpoolViewModel>();
    }
}
