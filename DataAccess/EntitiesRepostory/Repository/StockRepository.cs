using Core.Concrete.Entities.DataBaseTable.SingleEntity;
using Core.Concrete.Entities.DataBaseTable.SpoolTracking;
using DataAccess.EntitiesRepostory.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntitiesRepostory.Repository
{
    public class StockRepository : MpsGenericRepository<Stock>, IStockRepository
    {
        private readonly MpsDbContext _context;
        public StockRepository(MpsDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
