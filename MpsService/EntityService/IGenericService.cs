using Core.Abstract;
using System.Linq.Expressions;

namespace MpsService.EntityService
{
    public interface IGenericService<TEntity> where TEntity:class,new()
    {
        Task<TEntity> AddAsync(TEntity Entity);
        Task<TEntity> UpdateAsync(TEntity Entity);
        Task<bool> PassiveUpdateAsync(TEntity Entity);


        Task<IEnumerable<TEntity>> GetAllAsyncAmount(int value, int valu2, Expression<Func<TEntity, bool>> filter = null);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includeProperties);
        Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null,
            params Expression<Func<TEntity, object>>[] includeProperties);

        Task<IList<TEntity>> GetAllLastOrderByDesc(Expression<Func<TEntity, bool>> filter = null,
            params Expression<Func<TEntity, object>>[] includeProperties);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter);
        Task<int> CountAsync(Expression<Func<TEntity, bool>> filter);
    }
}
