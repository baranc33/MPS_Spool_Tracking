using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.SpoolWorkShopAssembly;

namespace MpsService.Mapping.ShipYardProjectSystemSpoolAndComponents
{
    public static class SpoolWorkShopAssemblyMpsMapper
    {
        //SpoolWorkShopAssembly 
        // SpoolWorkShopAssembly To ViewModel
        public static SpoolWorkShopAssemblyViewModel ToSpoolWorkShopAssemblyViewModel(SpoolWorkShopAssembly model)
        {
            return new SpoolWorkShopAssemblyViewModel
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
        //  ViewModel To SpoolWorkShopAssembly
        public static SpoolWorkShopAssembly ToSpoolWorkShopAssembly(SpoolWorkShopAssemblyViewModel model)
        {
            return new SpoolWorkShopAssembly
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

        //ICollection SpoolWorkShopAssembly To  ICollection ViewModel
        public static ICollection<SpoolWorkShopAssemblyViewModel> ToCollectionSpoolWorkShopAssemblyViewModel(ICollection<SpoolWorkShopAssembly> model)
        {
            return model.Select(b => new SpoolWorkShopAssemblyViewModel
            {
                Id = b.Id,


            }).ToList();
        }

    }
}
