using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.ViewModels.Employee;

namespace MpsService.Mapping.BranchAndEmployeeWork
{
    public static class EmployeeWorkMpsMapper
    {
        // EmployeeWork To ViewModel
        public static EmployeeWorkViewModel ToEmployeeWorkViewModel(EmployeeWork model)
        {
            return new EmployeeWorkViewModel
            {
                Id = model.Id,
                IsDelete = model.IsDelete,
                IsWork = model.IsWork,
                ReallyDeleted = model.ReallyDeleted,
                ModifiedTime = model.ModifiedTime,
                ModifiedUserName = model.ModifiedUserName,
                LastBackUpId = model.LastBackUpId,
                CreateDate = model.CreateDate,
                WorkName = model.WorkName,
                WorkDetail = model.WorkDetail,
            };
        }
        //  ViewModel To EmployeeWork
        public static EmployeeWork ToEmployeeWork(EmployeeWorkViewModel model)
        {
            return new EmployeeWork
            {
                Id = model.Id,
                IsDelete = model.IsDelete,
                IsWork = model.IsWork,
                ReallyDeleted = model.ReallyDeleted,
                ModifiedTime = model.ModifiedTime,
                ModifiedUserName = model.ModifiedUserName,
                LastBackUpId = model.LastBackUpId,
                CreateDate = model.CreateDate,
                WorkName = model.WorkName,
                WorkDetail = model.WorkDetail,
            };
        }

        //ICollection EmployeeWork To  ICollection ViewModel
        public static ICollection<EmployeeWorkViewModel> ToCollectionEmployeeWorkViewModel(ICollection<EmployeeWork> model)
        {
            return model.Select(b => new EmployeeWorkViewModel
            {
                Id = b.Id,
                WorkName = b.WorkName,
                WorkDetail = b.WorkDetail
            }).ToList();
        }

    }
}
