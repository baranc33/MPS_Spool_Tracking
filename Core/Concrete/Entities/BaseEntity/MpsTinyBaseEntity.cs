using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.Entities.BaseEntity
{
    public class MpsTinyBaseEntity
    {
        public uint Id { get; set; } 
        public bool IsDelete { get; set; }//=> Nesnenin Silinip Silinmediğini Belirten Özellik
        public bool IsWork { get; set; } //=> Nesnenin Kullanılır olup Olmadığını Belirten özellik.   
        public bool ReallyDeleted { get; set; } = true;// hiç bir şekilde  silinmesini istemediğimiz verilerde false yaparız
    }
}
