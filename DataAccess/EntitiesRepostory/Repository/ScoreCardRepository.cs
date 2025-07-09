using Core.Concrete.Entities.DataBaseTable.EmployeeData;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class ScoreCardRepository : MpsGenericRepository<ScoreCard>, IScoreCardRepository
    {
        private readonly MpsDbContext _context;
        public ScoreCardRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
