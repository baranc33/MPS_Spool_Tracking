using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.Entities.BaseEntity
{
    public class MpsBackUpBaseEntity:MpsStandartBaseEntity
    {
        public MpsBackUpBaseEntity()
        {
            // BackUpDosyaları silinemez.
            ReallyDeleted = false;
        }
        public string UserId { get; set; } = "System"; //=> Değişikliği Yapan Kullanıcı.
        public string Message { get; set; } = "System"; //=> Kim Nezaman Neyi Değiştirdi.
        public int BackUpCounter { get; set; } // Veride Yapılan Değişiklik Sayısını tutar

    }
}
