using Core.Abstract;
using Core.Concrete.Entities.BaseEntity;

namespace Core.Concrete.Entities.DataBaseTable.SingleEntity
{
    public class Stock : MpsStandartBaseEntity, IMpsEntity
    {
        public uint No{ get; set; }
        public string Name{ get; set; }
        public string Content{ get; set; }
        public ushort Amount{ get; set; }
        public float Price{ get; set; }
        public DateTime EntryTime{ get; set; }
        public DateTime ExitTime{ get; set; }
        public string SenderName{ get; set; }
        public uint ForProjectId{ get; set; }
    }
}
