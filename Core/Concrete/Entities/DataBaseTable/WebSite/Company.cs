using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.WebSite
{
    public class Company : MpsStandartBaseEntity, IMpsEntity
    {
        public Company()
        {
            // Bu verinin silinmemesi gerekiyor.  
            this.ReallyDeleted = false;
        }

        public string CompanyName { get; set; } // Navigasyon Bar için  
        public string CompanyMail { get; set; } // Navigasyon Bar için  
        public string CompanyLogo { get; set; } // Navigasyon Bar için  
        public string CompanyPhone { get; set; } // Navigasyon Bar için  
        public string Linkedin { get; set; } // Navigasyon Bar için  
        public string ContactSistemMail { get; set; } // Otomatik Gönderilecek Maillerin Adresini belirlemek için  
        public string ContactSistemMailPassword { get; set; } // Otomatik Gönderilecek Mail tanımlaması  
        public string MidWeekWorkTime { get; set; } // Footer için  
        public string SaturdayWorkTime { get; set; } // Footer için  
        public string SundayWorkTime { get; set; } // Footer için  
        public string CompanyCreateTime { get; set; } // Footer için  
    }
}
