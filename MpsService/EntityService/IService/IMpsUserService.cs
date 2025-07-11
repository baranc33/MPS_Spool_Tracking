using Core.Concrete.Entities.DataBaseTable.UsersData;
using Core.Concrete.ViewModels.User;
using Microsoft.AspNetCore.Identity;

namespace MpsService.EntityService.IService
{
    public interface IMpsUserService : IGenericService<MpsUser>
    {
        Task<ICollection<UserViewModel>> GetAllUser();
        Task<IdentityResult> CreateUser(UserSaveViewModel model);
        Task<UserViewModel> ModifiedAsync(UserViewModel model);
        Task<UserViewModel> GetUser(string Id);
        Task<ICollection<string>> GetRolesAsync(string UserName);

        Task<string> Login(LoginViewModel model);

    }
  
}
