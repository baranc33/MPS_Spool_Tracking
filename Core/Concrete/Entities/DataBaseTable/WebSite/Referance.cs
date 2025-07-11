using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.WebSite
{
    public class Referance : MpsStandardBaseEntity, IMpsEntity
    {
        public Referance()
        {
            this.ReallyDeleted = false;
        }
    }
}
