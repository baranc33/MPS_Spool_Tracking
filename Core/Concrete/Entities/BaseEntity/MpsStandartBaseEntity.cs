namespace Core.Concrete.Entities.BaseEntity
{
    public class MpsStandartBaseEntity : MpsTinyBaseEntity
    {


        public DateTime ModifiedTime { get; set; }  //=>  En Son Güncellenme Tarihi.
        public string ModifiedUserName { get; set; } //=> En Son Güncelliyen Kişi.
        public uint? LastBackUpId { get; set; } //=> Son Yapılan Değişikliğin Kaydını Tutan Id.
        public DateTime CreateDate { get; set; }  //==> Nesnenin ilk Oluşturulduğu Tarih.

    }
}