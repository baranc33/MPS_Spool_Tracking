using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.ViewModels.Brach;

namespace MpsService.Mapping.BranchAndEmployeeWork
{
    public static class BranchMpsMapper
    {

        // Branch To ViewModel
        public static BranchViewModel ToBranchViewModel(Branch model)
        {
            return new BranchViewModel
            {
                Id = model.Id,
                IsDeleted  = model.IsDeleted ,
                IsWork = model.IsWork,
                ReallyDeleted = model.ReallyDeleted,
                ModifiedTime = model.ModifiedTime,
                ModifiedUserName = model.ModifiedUserName,
                LastBackupId= model.LastBackupId,
                CreateDate = model.CreateDate,
                BranchName = model.BranchName,
                BranchDetail = model.BranchDetail,
            };
        }
        //  ViewModel To Branch
        public static Branch ToBranch( BranchViewModel model)
        {
            return new Branch
            {
                Id = model.Id,
                IsDeleted  = model.IsDeleted ,
                IsWork = model.IsWork,
                ReallyDeleted = model.ReallyDeleted,
                ModifiedTime = model.ModifiedTime,
                ModifiedUserName = model.ModifiedUserName,
                LastBackupId = model.LastBackupId,
                CreateDate = model.CreateDate,
                BranchName = model.BranchName,
                BranchDetail = model.BranchDetail,
            };
        }

        //ICollection Branch To  ICollection ViewModel
        public static ICollection<BranchViewModel> ToCollectionBranchViewModel(ICollection<Branch> model)
        {
            return model.Select(b => new BranchViewModel
            {
                Id = b.Id,
                BranchName = b.BranchName,
                BranchDetail = b.BranchDetail
            }).ToList();
        }

    }
}
