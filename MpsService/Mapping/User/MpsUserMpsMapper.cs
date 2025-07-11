using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using Core.Concrete.Entities.DataBaseTable.UsersData;
using Core.Concrete.ViewModels.Brach;
using Core.Concrete.ViewModels.User;

namespace MpsService.Mapping.User
{
    public static class MpsUserMpsMapper
    {
        //ICollection MpsUser To  ICollection ViewModel
        public static ICollection<UserViewModel> ToCollectionMpsUserViewModel(ICollection<MpsUser> model)
        {
            return model.Select(user => new UserViewModel
            {
                 Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                PasswordBackUp = user.PasswordBackUp,
                ModifiedUserName = user.ModifiedUserName,
                ModifiedTime = user.ModifiedTime,
                LastBackUpId = user.LastBackUpId,
                CreateTime = user.CreateTime,
                PhoneNumber = user.PhoneNumber,
              
                ReallyDeleted = user.ReallyDeleted,
                UseForPersonel = user.UseForPersonel,
            }).ToList();
        }


        //public static ICollection<UserViewModel> ToCollectionMpsUserViewModel(ICollection<MpsUser> user)
        //{
        //    ICollection<UserViewModel> userViewModels = new List<UserViewModel>();
        //    foreach (var item in user)
        //    {
        //        UserViewModel userViewModel = new UserViewModel()
        //        {
        //            Id = item.Id,
        //            UserName = item.UserName,
        //            Email = item.Email,
        //            PhoneNumber = item.PhoneNumber,

        //            PasswordBackUp = item.PasswordBackUp
        //        };
        //        userViewModels.Add(userViewModel);
        //    }
        //    return userViewModels;
        //}


        // UserSaveViewModel To   MpsUser
        public static MpsUser ToMpsUser(UserSaveViewModel user)
        {

            MpsUser MpsUser = new MpsUser()
            {
                UserName = user.UserName,
                Email = user.Email,
                PasswordBackUp=user.Password,
                ModifiedUserName = user.ModifiedUserName,
                PhoneNumber = user.PhoneNumber,
                ReallyDeleted = user.ReallyDeleted,
                UseForPersonel = user.UseForPersonel,
            };
            return MpsUser;
        }

        // MpsUser To   UserViewModel
        public static UserViewModel ToUserViewModel(MpsUser user)
        {
            UserViewModel userViewModel = new UserViewModel()
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                PasswordBackUp = user.PasswordBackUp,
                ModifiedUserName = user.ModifiedUserName,
                ModifiedTime = user.ModifiedTime,
                LastBackUpId = user.LastBackUpId,
                CreateTime = user.CreateTime,
                PhoneNumber = user.PhoneNumber,
                
                ReallyDeleted = user.ReallyDeleted,
                UseForPersonel = user.UseForPersonel,
              


            };
            return userViewModel;

        }



    }
}
