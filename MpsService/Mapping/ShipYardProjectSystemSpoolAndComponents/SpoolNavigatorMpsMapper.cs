using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.SpoolNavigator;

namespace MpsService.Mapping.ShipYardProjectSystemSpoolAndComponents
{
    public static class SpoolNavigatorMpsMapper
    {
        //SpoolNavigator
        // SpoolNavigator To ViewModel
        public static SpoolNavigatorViewModel ToSpoolNavigatorViewModel(SpoolNavigator model)
        {
            return new SpoolNavigatorViewModel
            {
                Id = model.Id,
                IsDeleted = model.IsDeleted,
                IsWork = model.IsWork,
                ReallyDeleted = model.ReallyDeleted,
        

            };
        }
        //  ViewModel To SpoolNavigator
        public static SpoolNavigator ToSpoolNavigator(SpoolNavigatorViewModel model)
        {
            return new SpoolNavigator
            {
                Id = model.Id,
                IsDeleted = model.IsDeleted,
                IsWork = model.IsWork,
                ReallyDeleted = model.ReallyDeleted,
                
            };
        }

        //ICollection SpoolNavigator To  ICollection ViewModel
        public static ICollection<SpoolNavigatorViewModel> ToCollectionSpoolNavigatorViewModel(ICollection<SpoolNavigator> model)
        {
            return model.Select(b => new SpoolNavigatorViewModel
            {
                Id = b.Id,


            }).ToList();
        }


    }
}
