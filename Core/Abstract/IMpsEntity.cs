namespace Core.Abstract
{
    public interface IMpsEntity
    {
         bool ReallyDeleted { get; set; } //// hiç bir şekilde  silinmesini istemediğimiz verilerde false yaparız

    }
}
 