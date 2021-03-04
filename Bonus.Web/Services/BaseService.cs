using System.Collections.Generic;
using System.Threading.Tasks;
using Bonus.Data.Models;
using Bonus.Data.Repositories;

namespace Bonus.Web.Services
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity>
        where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repositoryBase;

        public BaseService(IRepositoryBase<TEntity> repositoryBase)
        {
            this.repositoryBase = repositoryBase;
        }
        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await repositoryBase.CreateAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await repositoryBase.GetAllAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            return await repositoryBase.UpdateAsync(entity);
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            return await repositoryBase.DeleteAsync(entity);
        }
    }
}