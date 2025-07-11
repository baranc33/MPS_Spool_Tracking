using Core.Abstract;
using System.Linq.Expressions;

namespace DataAccess.EntitiesRepostory
{
    public interface IMpsGenericRepository<TEntity> where TEntity : class, IMpsEntity, new()
    {

        Task<IEnumerable<TEntity>> GetAllAsyncAmount(int value, int valu2, Expression<Func<TEntity, bool>> filter = null);


        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter);
        Task<int> CountAsync(Expression<Func<TEntity, bool>> filter);

        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includeProperties);
        Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null,
            params Expression<Func<TEntity, object>>[] includeProperties);

        Task<IList<TEntity>> GetAllLastOrderByDesc(Expression<Func<TEntity, bool>> filter = null,
            params Expression<Func<TEntity, object>>[] includeProperties);


        Task<(TEntity, bool, string)> AddAsync(TEntity Entity);
        Task<bool> AddRangeAsync(ICollection<TEntity> Entities);

        Task<TEntity> UpdateAsync(TEntity Entity);
        Task<bool> PassiveUpdateAsync(TEntity Entity);
        Task<string> DeleteAsync(TEntity Entity);

    }
    }
