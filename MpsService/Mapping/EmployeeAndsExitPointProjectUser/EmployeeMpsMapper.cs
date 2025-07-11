using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.ViewModels.Employee;

namespace MpsService.Mapping.EmployeeAndsExitPointProjectUser
{
    public static class EmployeeMpsMapper
    {
        // Employee To ViewModel
        public static EmployeeViewModel ToEmployeeViewModel(Employee model)
        {
            return new EmployeeViewModel
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
        //  ViewModel To Employee
        public static Employee ToEmployee(EmployeeViewModel model)
        {
            return new Employee
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

        //ICollection Employee To  ICollection ViewModel
        public static ICollection<EmployeeViewModel> ToCollectionEmployeeViewModel(ICollection<Employee> model)
        {
            return model.Select(b => new EmployeeViewModel
            {
                Id = b.Id,


            }).ToList();
        }

    }
}
