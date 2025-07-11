using Core.Concrete.Entities.BaseEntity;
using Core.Concrete.ViewModels.Employee;

namespace Core.Concrete.ViewModels.Project
{
    public class ProjectDetailsViewModel : MpsStandardBaseEntity
    {

        // Associated shipyard
        public string ShipYardManagerName { get; set; }
        public byte ShipYardActiveProject { get; set; }
        public string ShipYardName { get; set; }
        public string ProjectName { get; set; }  
        public string ProjectManagerName { get; set; }
        public string ProjectManagerLastName { get; set; }
        public DateTime ProjectManagerBirthDayDate { get; set; }
        public string ProjectManagerPhone { get; set; }
        public DateTime ProjectManagerWorkStartDate { get; set; }
        public string ProjectManagerLinkedin { get; set; }
        public string ProjectManagerPicture { get; set; }
        public DateTime ProjectStartDate { get; set; } 
        public DateTime? ProjectFinishDate { get; set; } = null; 
        public byte CircutSystemsCount { get; set; }
        public ushort TotalSpoolCount { get; set; }
        public ulong ProjectManagerEmployeeId { get; set; }
        public EmployeeViewModel ProjectManagerEmployee { get; set; } //=> Personel Bilgileri 

        public DateTime ProjectManagerStartDate { get; set; }

    
        public ICollection<(ulong id, ulong CountSpool, string name)> circutSystems{ get; set; }

        public ICollection<EmployeeProjectViewModel> EmployeeProjects { get; set; }


 

      

    }














}
