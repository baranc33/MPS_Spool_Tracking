
using Core.Concrete.ViewModels.ScoreCard;

namespace MpsService.EntityService.IService
{
    public interface IScoreCardService
    {
        Task<EmployeeScoreCardViewModel> GetAsync(uint Id);
        Task<ICollection<EmployeeScoreCardViewModel>> GetAllAsync();
        Task<(bool, string)>CreateAsync(EmployeeScoreCardViewModel Entity);
        Task<(bool, string)>ModifiedAsync(EmployeeScoreCardViewModel Entity);
        Task<(bool, string)> PassiveAsync(uint Id);

    }
}
