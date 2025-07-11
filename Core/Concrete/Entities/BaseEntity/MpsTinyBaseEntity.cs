namespace Core.Concrete.Entities.BaseEntity
{
    public  class MpsTinyBaseEntity
    {
        public ulong Id { get; set; }
        public bool IsDelete { get; set; }//=> Nesnenin Silinip Silinmediğini Belirten Özellik
        public bool IsWork { get; set; } //=> Nesnenin Kullanılır olup Olmadığını Belirten özellik.   
        public bool ReallyDeleted { get; set; } = true;// hiç bir şekilde  silinmesini istemediğimiz verilerde false yaparız
                                                 
    }
}
