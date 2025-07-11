namespace Core.Helper.Extentions
{
    public static class MyDateTimeExtensions
    {
        public static string ToCustomFormat(this DateTime Time)
        {
            // Get the following var out of the database
            String format = "dd/MM/yyyy hh:mm";
            // Converts the local DateTime to a string 
            // using the custom format string and display.
            String result = Time.ToString(format);
            return result;
        }
    }
    //public class DateTimeBinder : DefaultModelBinder
    //{
    //    public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
    //    {

    //        var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);


    //        DateTime date;
    //        var displayFormat = SmartSession.DateTimeFormat;

    //        if (DateTime.TryParseExact(value.AttemptedValue, displayFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
    //        {
    //            return date;
    //        }
    //        else
    //        {
    //            bindingContext.ModelState.AddModelError(bindingContext.ModelName, "Invalid Format");
    //        }


    //        return base.BindModel(controllerContext, bindingContext);
    //    }
    //}
}
