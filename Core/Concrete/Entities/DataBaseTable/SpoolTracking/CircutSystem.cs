using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.SpoolTracking
{
    public class CircutSystem : MpsTinyBaseEntity, IMpsEntity
    {
        public string SystemName { get; set; }

        public Project Project { get; set; }
        public uint ProjectId { get; set; }
        public ICollection<Spool> Spools { get; set; }
        public ICollection<SpoolNavigator> SpoolNavigators { get; set; }


    }
}
