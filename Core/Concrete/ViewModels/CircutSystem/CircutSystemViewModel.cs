using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Project;
using Core.Concrete.ViewModels.Spool;
using Core.Concrete.ViewModels.SpoolNavigator;

namespace Core.Concrete.ViewModels.CircutSystem
{
    public class CircutSystemViewModel : MpsStandardBaseEntity
    {
        public DateTime CircutSystemStartDate { get; set; }
        public DateTime CircutSystemFinishDate { get; set; }
        public string SystemName { get; set; }
        public ushort TotalSpoolCount { get; set; }
        public ulong ProjectId { get; set; }
        public ProjectViewModel Project { get; set; }
        public ICollection<SpoolViewModel> Spools { get; set; } = new List<SpoolViewModel>();
        public ICollection<SpoolNavigatorViewModel> SpoolNavigators { get; set; } = new List<SpoolNavigatorViewModel>();

    }
}
