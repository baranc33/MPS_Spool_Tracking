using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Brach;
using Core.Concrete.ViewModels.Project;
using Core.Concrete.ViewModels.SpoolAssembly;
using Core.Concrete.ViewModels.User;

namespace Core.Concrete.ViewModels.Employee
{
    public class EmployeeUserViewModel : MpsStandardBaseEntity
    {
        // bu tablo personel bilgileriyle kullanıcı bilgilerine hızlıca erişip işlem yapabilmek içindir.
        // Kullanıcı => personel => branş zincirlemesinde 
        // PersonelUser => personel , User , Branş  şeklinde 1 adım geriden işlem yapbilmeyi sağlar.
        //personel bilgilerinde yapılan güncellemeler burayıda tetiklemelidir.
        //

        public string UserId { get; set; }
        public UserViewModel User { get; set; } //=> Kullanıcı Bilgileri

        public ulong EmployeeId { get; set; }
        public EmployeeViewModel Employee { get; set; } //=> Personel Bilgileri 

        public ulong BranchId { get; set; }
        public BranchViewModel Branch { get; set; } //=> Personelin Çalıştığı Branş Bilgileri

        public ulong EmployeeWorkId { get; set; }
        public EmployeeWorkViewModel EmployeeWork { get; set; }//=> Personelin Yaptığı iş


        public ProjectViewModel Project { get; set; }

        public ICollection<EmployeeProjectViewModel> EmployeeProjects { get; set; } //=> Yetkili olduğu personeller
        public string Linkedin { get; set; }
        public string Picture { get; set; }
        public ICollection<SpoolAssemblyViewModel> AssemblyCheck { get; set; } // KontrolEttiği Montajlar

    }
}
