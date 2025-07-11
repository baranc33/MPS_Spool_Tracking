﻿using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.ViewModels.Employee;

namespace MpsService.Mapping.EmployeeAndsExitPointProjectUser
{
    public static class EmployeePointMpsMapper
    {
        // EmployeePoint To ViewModel
        public static EmployeePointViewModel ToEmployeePointViewModel(EmployeePoint model)
        {
            return new EmployeePointViewModel
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
        //  ViewModel To EmployeePoint
        public static EmployeePoint ToEmployeePoint(EmployeePointViewModel model)
        {
            return new EmployeePoint
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

        //ICollection EmployeePoint To  ICollection ViewModel
        public static ICollection<EmployeePointViewModel> ToCollectionEmployeePointViewModel(ICollection<EmployeePoint> model)
        {
            return model.Select(b => new EmployeePointViewModel
            {
                Id = b.Id,


            }).ToList();
        }

    }
}
