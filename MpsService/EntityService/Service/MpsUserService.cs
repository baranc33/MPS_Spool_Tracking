using Core.Concrete.Entities.DataBaseTable.UsersData;
using Core.Concrete.ViewModels.User;
using DataAccess.EntitiesRepostory;
using DataAccess.EntitiesRepostory.IRepository;
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
        private IMpsUserRepository _mpsUserRepository { get; }
        protected IUnitOfWork _unitOfWork { get; }
        public MpsUserService(IUnitOfWork unitOfWork, IMpsGenericRepository<MpsUser> repository, UserManager<MpsUser> userManager, SignInManager<MpsUser> signInManager, RoleManager<MpsRole> roleManager , IMpsUserRepository mpsUserRepository)
            : base(unitOfWork, repository)
        {
            this._mpsUserRepository = mpsUserRepository;
            this._unitOfWork= unitOfWork;

            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = roleManager;
        }

        public async Task<IdentityResult> CreateUser(UserSaveViewModel model)
        {
            MpsUser user = MpsUserMpsMapper.ToMpsUser(model);
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            return result;
        }


        public async Task<ICollection<UserViewModel>> GetAllUser()
        {
            ICollection<MpsUser> users = await _userManager.Users.AsNoTracking().ToListAsync();
            ICollection<UserViewModel> model = MpsUserMpsMapper.ToCollectionMpsUserViewModel(users);

            return model;
        }

        public async Task<string> Login(LoginViewModel model)
        {
            // Kullanıcı maille yada kullanıcı adıyla girmiş olabilir diye iki seçeneğide kontrol ediyoruz
            MpsUser user = new();
            if (model.UserName.Contains("@")) user = await _userManager.FindByEmailAsync(model.UserName);
            else user = await _userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                if (await _userManager.IsLockedOutAsync(user)) // true dönerse kitlidir
                {
                    return "Hesabınız Bir Süreliğine kitlenmiştir bir süre sonra tekrar deneyiniz";
                }
                else
                {
                    await _signInManager.SignOutAsync();

                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                    if (result.Succeeded)
                    {
                        await _userManager.ResetAccessFailedCountAsync(user);
                        return "Success";
                    }
                    else
                    {
                        await _userManager.AccessFailedAsync(user);// hhatalı girişi 1 arttır
                        int fail = await _userManager.GetAccessFailedCountAsync(user);// hatalı girişleri getir

                        if (fail == 3)
                        {// 3 başarısız giriş yapmak
                            await _userManager.SetLockoutEndDateAsync(user, new DateTimeOffset(DateTime.Now.AddMinutes(5)));
                            return "Hesabınız 5 dk boyunca kitlendi.";
                        }
                        // hatalı giriş mesajı
                        return $"{fail} Hatalı Giriş Yaptınız";

                    }
                }
            }
            else
            {
                return "Geçersiz kullanıcı adı veya  şifresi";
            }
        }

        public async Task<UserViewModel> ModifiedAsync(UserViewModel model)
        {
            MpsUser mpsUser = await _userManager.FindByIdAsync(model.Id);
            mpsUser.UserName = model.UserName;
            mpsUser.Email = model.Email;

            await _unitOfWork.SaveAsync();
            return model;
        }

        public async Task<UserViewModel> GetUser(string Id)
        {
            return MpsUserMpsMapper.ToUserViewModel
                (
                await _userManager.Users.Where(x => x.Id == Id).FirstOrDefaultAsync()
                );
        }

        public async Task<ICollection<string>> GetRolesAsync(string UserName)
        {

            return await _userManager.GetRolesAsync(await _mpsUserRepository.GetAsync(x => x.UserName== UserName));

        }
    }
}
