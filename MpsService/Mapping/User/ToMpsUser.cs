using Core.Concrete.Entities.DataBaseTable.UsersData;
using Core.Concrete.ViewModel.User;

namespace MpsService.Mapping.User
{
    public static class  ToMpsUser
    {

        public static MpsUser UserSaveViewModel(UserSaveViewModel user)
        {


            MpsUser MpsUser = new MpsUser()
            {
                UserName = user.UserName,
                Email = user.Email,
                PasswordBackUp=user.Password,
           

            };



            return MpsUser;
        }
    }
}
