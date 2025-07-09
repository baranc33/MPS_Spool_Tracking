using Core.Abstract;
using System.Linq.Expressions;

namespace DataAccess.EntitiesRepostory
{
    public interface IMpsGenericRepository<T> where T : class, IMpsEntity, new()
    {

        Task<IEnumerable<T>> GetAllAsyncAmount(int value, int valu2, Expression<Func<T, bool>> filter = null);


        Task<bool> AnyAsync(Expression<Func<T, bool>> filter);
        Task<int> CountAsync(Expression<Func<T, bool>> filter);

        Task<T> GetAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includeProperties);
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> filter = null,
            params Expression<Func<T, object>>[] includeProperties);

        Task<IList<T>> GetAllLastOrderByDesc(Expression<Func<T, bool>> filter = null,
            params Expression<Func<T, object>>[] includeProperties);


        Task<T> AddAsync(T Entity);
        Task<bool> AddRangeAsync(ICollection<T> Entities);

        Task<T> UpdateAsync(T Entity);
        Task<bool> PassiveUpdateAsync(T Entity);
        Task<string> DeleteAsync(T Entity);

    }
    }
