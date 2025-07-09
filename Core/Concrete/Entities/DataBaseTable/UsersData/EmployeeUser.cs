using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;

namespace Core.Concrete.Entities.DataBaseTable.UsersData
{
    public class EmployeeUser : MpsStandartBaseEntity, IMpsEntity
    {

        // bu tablo personel bilgileriyle kullanıcı bilgilerine hızlıca erişip işlem yapabilmek içindir.
        // Kullanıcı => personel => branş zincirlemesinde 
        // PersonelUser => personel , User , Branş  şeklinde 1 adım geriden işlem yapbilmeyi sağlar.
        //personel bilgilerinde yapılan güncellemeler burayıda tetiklemelidir.
        //
        public string UserId{ get; set; }
        public MpsUser User { get; set; } //=> Kullanıcı Bilgileri

        public uint EmployeeId{ get; set; }
        public Employee Employee { get; set; } //=> Personel Bilgileri 

        public uint BranchId{ get; set; }
        public Branch Branch { get; set; } //=> Personelin Çalıştığı Branş Bilgileri

        public uint EmployeeWorkId { get; set; }
        public EmployeeWork EmployeeWork { get; set; }//=> Personelin Yaptığı iş


        public Project Project { get; set; }

        public ICollection<EmployeeProject> EmployeeProjects { get; set; } //=> Yetkili olduğu personeller
        public  string Linkedin { get; set; }
        public  string Picture { get; set; }

    }
}
