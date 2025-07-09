using Core.Concrete.Entities.DataBaseTable.UsersData;
using Core.Concrete.ViewModel;
using Core.Concrete.ViewModel.User;
using DataAccess.EntitiesRepostory;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MpsService.EntityService.IService;
using MpsService.Mapping.User;

namespace MpsService.EntityService.Service
{
    public class MpsUserService : GenericService<MpsUser>, IMpsUserService
    {
        protected UserManager<MpsUser> _userManager { get; }
        protected SignInManager<MpsUser> _signInManager { get; }

        protected RoleManager<MpsRole> _roleManager { get; }
        public MpsUserService(IUnitOfWork unitOfWork, IMpsGenericRepository<MpsUser> repository, UserManager<MpsUser> userManager, SignInManager<MpsUser> signInManager, RoleManager<MpsRole> roleManager) : base(unitOfWork, repository)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = roleManager;
        }

        public async Task<IdentityResult> CreateUser(UserSaveViewModel model)
        {
            MpsUser user = ToMpsUser.UserSaveViewModel(model);
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            return result;
        }

     
        public async Task<ICollection<UserViewModel>> GetAllUser()
        {
            ICollection<MpsUser> users = await _userManager.Users.AsNoTracking().ToListAsync();
            ICollection<UserViewModel> model = MpsUserTo.ICollection_MpsUserToUserViewModel(users);

            return model;
        }

        public async Task<ICollection<MpsUser>> GetEngineerList()
        {
            throw new NotImplementedException();
        }
 

        public async Task<string> Login(LoginViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
