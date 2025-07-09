using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.WebSite
{
    public class Contact : MpsStandartBaseEntity, IMpsEntity
    {
        public Contact()
        {
            this.ReallyDeleted = false;
        }
    }
}
