using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.WebSite
{
    public class Contact : MpsStandardBaseEntity, IMpsEntity
    {
        public Contact()
        {
            this.ReallyDeleted = false;
        }
    }
}
