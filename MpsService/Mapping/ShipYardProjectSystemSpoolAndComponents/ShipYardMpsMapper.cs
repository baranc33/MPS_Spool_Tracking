using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.ShipYard;

namespace MpsService.Mapping.ShipYardProjectSystemSpoolAndComponents
{
    public static class ShipYardMpsMapper
    {
        //ShipYard
        // ShipYard To ViewModel
        public static ShipYardViewModel ToShipYardViewModel(ShipYard model)
        {
            return new ShipYardViewModel
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
        //  ViewModel To ShipYard
        public static ShipYard ToShipYard(ShipYardViewModel model)
        {
            return new ShipYard
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

        //ICollection ShipYard To  ICollection ViewModel
        public static ICollection<ShipYardViewModel> ToCollectionShipYardViewModel(ICollection<ShipYard> model)
        {
            return model.Select(b => new ShipYardViewModel
            {
                Id = b.Id,


            }).ToList();
        }

    }
}
