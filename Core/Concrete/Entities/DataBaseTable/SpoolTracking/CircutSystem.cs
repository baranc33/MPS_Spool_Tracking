using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.SpoolTracking
{
    public class CircutSystem : MpsStandartBaseEntity, IMpsEntity
    {
        public string SystemName { get; set; }

        public ulong ProjectId { get; set; }
        public Project Project { get; set; }
        public ushort CircutSystemTotalSpoolCount { get; set; }
        public ICollection<Spool> Spools { get; set; }
        public ICollection<SpoolNavigator> SpoolNavigators { get; set; }
        public DateTime CircutSystemStartDate { get; set; }
        public DateTime? CircutSystemFinishDate { get; set; }

    }
}
