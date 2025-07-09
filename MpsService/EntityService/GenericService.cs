using Core.Abstract;
using DataAccess.EntitiesRepostory;
using System.Linq.Expressions;

namespace MpsService.EntityService
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class, IMpsEntity, new()
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMpsGenericRepository<TEntity> _repository;
        public GenericService(IUnitOfWork unitOfWork, IMpsGenericRepository<TEntity> repository)
        {
            _repository=repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<TEntity> AddAsync(TEntity Entity)
        {
            await _repository.AddAsync(Entity);
            await _unitOfWork.SaveAsync();
            return Entity;
        }
        public async Task<bool> PassiveUpdateAsync(TEntity Entity)
        {
            bool result= await _repository.PassiveUpdateAsync(Entity);

            if (result)
            {
                await _unitOfWork.SaveAsync();
            }
            return result;
        }

        public async Task<TEntity> UpdateAsync(TEntity Entity)
        {
            await _repository.UpdateAsync(Entity);
            await _unitOfWork.SaveAsync();
            return Entity;
        }
        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter)
        {
           return await _repository.AnyAsync(filter);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _repository.CountAsync(filter);

        }



        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return await _repository.GetAllAsync(filter, includeProperties);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsyncAmount(int value, int valu2, Expression<Func<TEntity, bool>> filter = null)
        {
           return await _repository.GetAllAsyncAmount(value, valu2, filter);

        }

        public async Task<IList<TEntity>> GetAllLastOrderByDesc(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return await _repository.GetAllLastOrderByDesc(filter, includeProperties);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return await _repository.GetAsync(filter, includeProperties);
        }

      
    }
}
