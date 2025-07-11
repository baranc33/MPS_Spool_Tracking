using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.ViewModels.Employee;

namespace MpsService.Mapping.EmployeeAndsExitPointProjectUser
{
    public static class EmployeeProjectMpsMapper
    {
        // EmployeeProject To ViewModel
        public static EmployeeProjectViewModel ToEmployeeProjectViewModel(EmployeeProject model)
        {
            return new EmployeeProjectViewModel
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
        //  ViewModel To EmployeeProject
        public static EmployeeProject ToEmployeeProject(EmployeeProjectViewModel model)
        {
            return new EmployeeProject
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

        //ICollection EmployeeProject To  ICollection ViewModel
        public static ICollection<EmployeeProjectViewModel> ToCollectionEmployeeProjectViewModel(ICollection<EmployeeProject> model)
        {
            return model.Select(b => new EmployeeProjectViewModel
            {
                Id = b.Id,


            }).ToList();
        }

    }
}
