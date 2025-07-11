using Core.Concrete.ViewModels.ScoreCard;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;

namespace MpsService.Mapping.ScoreCard
{
    public static class ScoreCardMpsMapper
    // EmployeeScoreCard To ViewModel
    {
        public static EmployeeScoreCardViewModel ToEmployeeScoreCardViewModel(EmployeeScoreCard model)
        {
            return new EmployeeScoreCardViewModel
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
        //  ViewModel To EmployeeScoreCard
        public static EmployeeScoreCard ToEmployeeScoreCard(EmployeeScoreCardViewModel model)
        {
            return new EmployeeScoreCard
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

        //ICollection EmployeeScoreCard To  ICollection ViewModel
        public static ICollection<EmployeeScoreCardViewModel> ToCollectionEmployeeScoreCardViewModel(ICollection<EmployeeScoreCard> model)
        {
            return model.Select(b => new EmployeeScoreCardViewModel
            {
                Id = b.Id,


            }).ToList();
        }

    }
}
