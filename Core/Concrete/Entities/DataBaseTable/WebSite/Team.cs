using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.WebSite
{
    public class Team : MpsStandartBaseEntity, IMpsEntity
    {
        public Team()
        {
            this.ReallyDeleted = false;
        }
    }
}
