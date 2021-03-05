using System.Collections.Generic;
using System.Threading.Tasks;
using Bonus.Core.Services.Interfaces;
using Bonus.Data.Repositories;

namespace Bonus.Core.Services
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity>
        where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repositoryBase;
        
        public BaseService(IRepositoryBase<TEntity> repositoryBase) =>
            this.repositoryBase = repositoryBase;
        
        public async Task<TEntity> CreateAsync(TEntity entity) =>
            await repositoryBase.CreateAsync(entity);

        public async Task<IEnumerable<TEntity>> GetAllAsync() => 
            await repositoryBase.GetAllAsync();

        public async Task<TEntity> UpdateAsync(TEntity entity) =>
            await repositoryBase.UpdateAsync(entity);

        public async Task<TEntity> DeleteAsync(TEntity entity) =>
            await repositoryBase.DeleteAsync(entity);
    }
}