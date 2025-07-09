using Core.Concrete.Entities.DataBaseTable.UsersData;
using Core.Concrete.ViewModel.User;

namespace MpsService.Mapping.User
{
    public static class MpsUserTo
    {


        public static ICollection<UserViewModel> ICollection_MpsUserToUserViewModel(ICollection<MpsUser> user)
        {


            ICollection<UserViewModel> userViewModels = new List<UserViewModel>();
            foreach (var item in user)
            {
                UserViewModel userViewModel = new UserViewModel()
                {
                    Id = item.Id,
                    UserName = item.UserName,
                    Email = item.Email,
                    PhoneNumber = item.PhoneNumber,

                    PasswordBackUp = item.PasswordBackUp
                };
                userViewModels.Add(userViewModel);
            }
            return userViewModels;
        }
    }
}
