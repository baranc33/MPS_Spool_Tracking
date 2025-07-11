using Core.Concrete.Entities.DataBaseTable.UsersData;
using Core.Concrete.ViewModels.Employee;

namespace MpsService.Mapping.EmployeeAndsExitPointProjectUser
{
    public static class EmployeeUserMpsMapper
    {
        // EmployeeUser To ViewModel
        public static EmployeeUserViewModel ToEmployeeUserViewModel(EmployeeUser model)
        {
            return new EmployeeUserViewModel
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
        //  ViewModel To EmployeeUser
        public static EmployeeUser ToEmployeeUser(EmployeeUserViewModel model)
        {
            return new EmployeeUser
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

        //ICollection EmployeeUser To  ICollection ViewModel
        public static ICollection<EmployeeUserViewModel> ToCollectionEmployeeUserViewModel(ICollection<EmployeeUser> model)
        {
            return model.Select(b => new EmployeeUserViewModel
            {
                Id = b.Id,


            }).ToList();
        }

    }
}