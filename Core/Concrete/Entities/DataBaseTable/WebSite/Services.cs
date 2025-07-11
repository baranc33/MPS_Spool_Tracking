using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.WebSite
{
    public class Services : MpsStandardBaseEntity, IMpsEntity
    {
        public Services()
        {
            this.ReallyDeleted = false;
        }
    }
}
