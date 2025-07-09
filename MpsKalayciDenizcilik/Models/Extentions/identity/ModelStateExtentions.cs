using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MpsKalayciDenizcilik.Models.Extentions.identity
{
    public static class ModelStateExtentions
    {


        public static void AddModelErrorList(this ModelStateDictionary modelState, List<string> errors)
        {
            errors.ForEach(x =>
            {
                modelState.AddModelError(string.Empty, x);
            });
        }


    }
}
