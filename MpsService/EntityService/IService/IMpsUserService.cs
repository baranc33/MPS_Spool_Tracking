using Core.Concrete.Entities.DataBaseTable.UsersData;
using Core.Concrete.ViewModel;
using Core.Concrete.ViewModel.User;
using Microsoft.AspNetCore.Identity;

namespace MpsService.EntityService.IService
{
    public interface IMpsUserService : IGenericService<MpsUser>
    {
        Task<ICollection<UserViewModel>> GetAllUser();
        Task<IdentityResult> CreateUser(UserSaveViewModel model);
  
        Task<ICollection<MpsUser>> GetEngineerList();

        Task<string> Login(LoginViewModel model);
    }
  
}
