using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.WebSite
{
    public class AboutUs : MpsStandartBaseEntity, IMpsEntity
    {
        public AboutUs()
        {
            this.ReallyDeleted = false; 
        }
        public string Golas{ get; set; }
        public string Vision{ get; set; }
        public string ValueTitle1{ get; set; }
        public string ValueContent1 { get; set; }
        public string ValueTitle2{ get; set; }
        public string ValueContent2 { get; set; }
        public string ValueTitle3{ get; set; }
        public string ValueContent3 { get; set; }
    }

}
