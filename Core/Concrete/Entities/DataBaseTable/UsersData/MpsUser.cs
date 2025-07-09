using Core.Abstract;
using Microsoft.AspNetCore.Identity;

namespace Core.Concrete.Entities.DataBaseTable.UsersData
{
    public class MpsUser : IdentityUser, IMpsEntity
    {
        public bool ReallyDeleted { get ; set ; } = true;
        public bool UseForPersonel { get ; set ; } = true;

        public EmployeeUser EmployeeUser { get; set; }

        public string PasswordBackUp { get; set; }

    }
}
