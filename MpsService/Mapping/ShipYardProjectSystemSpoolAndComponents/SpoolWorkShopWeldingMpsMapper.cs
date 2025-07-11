using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.SpoolWorkShopWelding;

namespace MpsService.Mapping.ShipYardProjectSystemSpoolAndComponents
{
    public static class SpoolWorkShopWeldingMpsMapper
    {
        //SpoolWorkShopWelding 
        // SpoolWorkShopWelding To ViewModel
        public static SpoolWorkShopWeldingViewModel ToSpoolWorkShopWeldingViewModel(SpoolWorkShopWelding model)
        {
            return new SpoolWorkShopWeldingViewModel
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
        //  ViewModel To SpoolWorkShopWelding
        public static SpoolWorkShopWelding ToSpoolWorkShopWelding(SpoolWorkShopWeldingViewModel model)
        {
            return new SpoolWorkShopWelding
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

        //ICollection SpoolWorkShopWelding To  ICollection ViewModel
        public static ICollection<SpoolWorkShopWeldingViewModel> ToCollectionSpoolWorkShopWeldingViewModel(ICollection<SpoolWorkShopWelding> model)
        {
            return model.Select(b => new SpoolWorkShopWeldingViewModel
            {
                Id = b.Id,


            }).ToList();
        }

    }
}
