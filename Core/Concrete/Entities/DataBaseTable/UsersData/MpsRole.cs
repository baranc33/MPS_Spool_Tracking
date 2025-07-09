using Core.Abstract;
using Microsoft.AspNetCore.Identity;

namespace Core.Concrete.Entities.DataBaseTable.UsersData
{
    public class MpsRole : IdentityRole, IMpsEntity
    {

        //Developer, Admin ,  Manager ,  WorkShopManager ,WorkShopEmploye ,Puantör , ProjectManager , Enginier , TrackingUser , 
        public bool ReallyDeleted { get; set; } = false;
    }
}
