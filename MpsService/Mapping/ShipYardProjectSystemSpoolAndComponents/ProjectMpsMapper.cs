using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.Project;

namespace MpsService.Mapping.ShipYardProjectSystemSpoolAndComponents
{
    public static class ProjectMpsMapper
    {
        //Project
        // Project To ViewModel
        public static ProjectViewModel ToProjectViewModel(Project model)
        {
            return new ProjectViewModel
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
        //  ViewModel To Project
        public static Project ToProject(ProjectViewModel model)
        {
            return new Project
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

        //ICollection Project To  ICollection ViewModel
        public static ICollection<ProjectViewModel> ToCollectionProjectViewModel(ICollection<Project> model)
        {
            return model.Select(b => new ProjectViewModel
            {
                Id = b.Id,


            }).ToList();
        }

    }
}
