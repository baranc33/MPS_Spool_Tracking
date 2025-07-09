using Core.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.EntitiesRepostory
{
    public class MpsGenericRepository<TEntity> : IMpsGenericRepository<TEntity>
where TEntity : class, IMpsEntity, new()
    {

        protected readonly MpsDbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public MpsGenericRepository(MpsDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbSet;// burdan nesne üstündeki verilere erişebilio


            if (includeProperties != null)
            {
                query = query.Where(filter);
                
            }
            if (includeProperties.Any())
            {
                foreach (var includeproperty in includeProperties)
                {
                    query = query.Include(includeproperty);

                }
            }

            return await query.SingleOrDefaultAsync();
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbSet;// burdan nesne üstündeki verilere erişebilio

            if (filter!=null)
            {
                query = query.Where(filter);
            }

            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            return await query.AsNoTracking().ToListAsync();
        }


        public async Task<IList<TEntity>> GetAllLastOrderByDesc(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbSet;// burdan nesne üstündeki verilere erişebilio

            if (filter!=null)
            {
                query = query.Where(filter);
            }

            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            return await query.AsNoTracking().OrderDescending().ToListAsync();
        }



        public Task<IEnumerable<TEntity>> GetAllAsyncAmount(int value, int valu2, Expression<Func<TEntity, bool>> filter = null)
        {
            IEnumerable<TEntity> query = _dbSet; // burdan nesne üstündeki verilere erişebilio

            if (filter != null)
            {
                query = query.Where(filter.Compile()); // Fixed: Use filter.Compile() to apply the filter to IEnumerable
            }

            return Task.FromResult(query.Skip(value).Take(valu2)); // Fixed: Use Skip and Take to implement range
        }


        public async Task<TEntity> AddAsync(TEntity Entity)
        {
            await _dbSet.AddAsync(Entity);
            return Entity;
        }

        public async Task<bool> AddRangeAsync(ICollection<TEntity> Entities)
        {
            try
            {
                await _dbSet.AddRangeAsync(Entities);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity Entity)
        {
            await Task.Run(() =>
            {
                _dbSet.Update(Entity);
            });
            return Entity;
        }
        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _dbSet.AnyAsync(filter);
        }


        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _dbSet.CountAsync(filter);

        }

        public async Task<bool> PassiveUpdateAsync(TEntity Entity)
        {
            await Task.Run(() =>
            {
                _dbSet.Update(Entity);
            });
            return true;
        }
      

        public async Task<string> DeleteAsync(TEntity Entity)
        {
           
            if (Entity.ReallyDeleted)
            {
                await Task.Run(() =>
                {
                    _dbSet.Remove(Entity);
                });
                return "Başarıyla silindi.";
            }
            else
                return "Verinin Silinmemesi için Engel Koyulmuş";

        }

    }
}
