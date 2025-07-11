using Core.Abstract;
using Microsoft.AspNetCore.Identity;

namespace Core.Concrete.Entities.DataBaseTable.UsersData
{
    public class MpsUser : IdentityUser, IMpsEntity
    {
     
        public EmployeeUser EmployeeUser { get; set; }

        public string PasswordBackUp { get; set; }

        public bool IsWork { get; set; }
        public bool IsDelete { get; set; }
        public bool ReallyDeleted { get; set; }
        public bool UseForPersonel { get; set; }

        public DateTime ModifiedTime { get; set; }  //=>  En Son Güncellenme Tarihi.
        public string ModifiedUserName { get; set; } //=> En Son Güncelliyen Kişi.
        public uint? LastBackUpId { get; set; } //=> Son Yapılan Değişikliğin Kaydını Tutan Id.
        public DateTime CreateTime { get; set; }  //==> Nesnenin ilk Oluşturulduğu Tarih.

    }
}
