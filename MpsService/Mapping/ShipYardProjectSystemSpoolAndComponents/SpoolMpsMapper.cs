using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.Spool;

namespace MpsService.Mapping.ShipYardProjectSystemSpoolAndComponents
{
    public static class SpoolMpsMapper
    {
        //Spool
        // Spool To ViewModel
        public static SpoolViewModel ToSpoolViewModel(Spool model)
        {
            return new SpoolViewModel
            {
                Id = model.Id,
                IsDeleted = model.IsDeleted,
                IsWork = model.IsWork,
                ReallyDeleted = model.ReallyDeleted,
                ModifiedTime = model.ModifiedTime,
                ModifiedUserName = model.ModifiedUserName,
                LastBackupId = model.LastBackupId,
                CreateDate = model.CreateDate,

            };
        }
        //  ViewModel To Spool
        public static Spool ToSpool(SpoolViewModel model)
        {
            return new Spool
            {
                Id = model.Id,
                IsDeleted = model.IsDeleted,
                IsWork = model.IsWork,
                ReallyDeleted = model.ReallyDeleted,
                ModifiedTime = model.ModifiedTime,
                ModifiedUserName = model.ModifiedUserName,
                LastBackupId = model.LastBackupId,
                CreateDate = model.CreateDate,
            };
        }

        //ICollection Spool To  ICollection ViewModel
        public static ICollection<SpoolViewModel> ToCollectionSpoolViewModel(ICollection<Spool> model)
        {
            return model.Select(b => new SpoolViewModel
            {
                Id = b.Id,


            }).ToList();
        }

    }
}
