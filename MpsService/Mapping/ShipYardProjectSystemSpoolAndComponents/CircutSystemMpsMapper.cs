using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.CircutSystem;

namespace MpsService.Mapping.ShipYardProjectSystemSpoolAndComponents
{
    public static class CircutSystemMpsMapper
    {
        //CircutSystem
        // CircutSystem To ViewModel
        public static CircutSystemViewModel ToCircutSystemViewModel(CircutSystem model)
        {
            return new CircutSystemViewModel
            {
                Id = model.Id,
                IsDelete = model.IsDelete,
                IsWork = model.IsWork,
                ReallyDeleted = model.ReallyDeleted,
                ModifiedTime = model.ModifiedTime,
                ModifiedUserName = model.ModifiedUserName,
                LastBackUpId = model.LastBackUpId,
                CreateDate = model.CreateDate,

            };
        }
        //  ViewModel To CircutSystem
        public static CircutSystem ToCircutSystem(CircutSystemViewModel model)
        {
            return new CircutSystem
            {
                Id = model.Id,
                IsDelete = model.IsDelete,
                IsWork = model.IsWork,
                ReallyDeleted = model.ReallyDeleted,
                ModifiedTime = model.ModifiedTime,
                ModifiedUserName = model.ModifiedUserName,
                LastBackUpId = model.LastBackUpId,
                CreateDate = model.CreateDate,
            };
        }

        //ICollection CircutSystem To  ICollection ViewModel
        public static ICollection<CircutSystemViewModel> ToCollectionCircutSystemViewModel(ICollection<CircutSystem> model)
        {
            return model.Select(b => new CircutSystemViewModel
            {
                Id = b.Id,


            }).ToList();
        }

    }
}
