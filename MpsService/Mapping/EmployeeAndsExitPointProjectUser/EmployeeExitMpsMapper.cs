using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.ViewModels.Employee;

namespace MpsService.Mapping.EmployeeAndsExitPointProjectUser
{
    public static class EmployeeExitMpsMapper
    {
        // EmployeeExit To ViewModel
        public static EmployeeExitViewModel ToEmployeeExitViewModel(EmployeeExit model)
        {
            return new EmployeeExitViewModel
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
        //  ViewModel To EmployeeExit
        public static EmployeeExit ToEmployeeExit(EmployeeExitViewModel model)
        {
            return new EmployeeExit
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

        //ICollection EmployeeExit To  ICollection ViewModel
        public static ICollection<EmployeeExitViewModel> ToCollectionEmployeeExitViewModel(ICollection<EmployeeExit> model)
        {
            return model.Select(b => new EmployeeExitViewModel
            {
                Id = b.Id,
     

            }).ToList();
        }

    }
}




 