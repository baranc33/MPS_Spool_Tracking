using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.WebSite
{
    public class Services : MpsStandartBaseEntity, IMpsEntity
    {
        public Services()
        {
            this.ReallyDeleted = false;
        }
    }
}
