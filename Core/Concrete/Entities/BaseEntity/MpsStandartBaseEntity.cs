using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.Entities.BaseEntity
{
    public class MpsStandartBaseEntity:MpsTinyBaseEntity
    {
        public DateTime ModifiedTime { get; set; }  //=>  En Son Güncellenme Tarihi.
        public string ModifiedUserName { get; set; } //=> En Son Güncelliyen Kişi.
        public int? LastBackUpId { get; set; } //=> Son Yapılan Değişikliğin Kaydını Tutan Id.
        public DateTime CreateTime { get; set; }  //==> Nesnenin ilk Oluşturulduğu Tarih.
        public string CreateUser { get; set; } //= => Nesneyi Oluşturan Kullanıcının Kullanıcı Adı.
      


    }
}
