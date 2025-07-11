using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.SingleEntity
{
    public class OtomaticSystemCode : MpsStandardBaseEntity,IMpsEntity
    {
        public OtomaticSystemCode()
        {
            ReallyDeleted = true;
        }
        public uint ManuelId { get; set; } //=> Oluşturulan veri yada koda özel erişim için                    
   
        public string Title { get; set; }  //=> Çalıştırılacak Kodun Başlığı
        public string Description { get; set; } //=> Açıklaması
        public string HashValue { get; set; } //=> eğer bir şifre kaydedilecek şifreyi şifrelemek için
  
        public string Value1 { get; set; } //=> Girilmesi gereken değer olursa
        public string Value2 { get; set; }//=> Girilmesi gereken değer olursa
    }
}
