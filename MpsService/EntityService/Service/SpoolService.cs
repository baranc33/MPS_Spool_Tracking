using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory;
using MpsService.EntityService.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpsService.EntityService.Service
{
    public class SpoolService : GenericService<Spool>, ISpoolService
    {
        public SpoolService( IUnitOfWork unitOfWork, IMpsGenericRepository<Spool> repository) : base(unitOfWork, repository)
        {
        }
    }
}
