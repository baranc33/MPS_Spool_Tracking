using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.SpoolAssembly;

namespace MpsService.Mapping.ShipYardProjectSystemSpoolAndComponents
{
    public static class SpoolAssemblyMpsMapper
    {
        //SpoolAssembly
        // SpoolAssembly To ViewModel
        public static SpoolAssemblyViewModel ToSpoolAssemblyViewModel(SpoolAssembly model)
        {
            return new SpoolAssemblyViewModel
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
        //  ViewModel To SpoolAssembly
        public static SpoolAssembly ToSpoolAssembly(SpoolAssemblyViewModel model)
        {
            return new SpoolAssembly
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

        //ICollection SpoolAssembly To  ICollection ViewModel
        public static ICollection<SpoolAssemblyViewModel> ToCollectionSpoolAssemblyViewModel(ICollection<SpoolAssembly> model)
        {
            return model.Select(b => new SpoolAssemblyViewModel
            {
                Id = b.Id,


            }).ToList();
        }

    }
}
