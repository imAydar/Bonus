using System;
using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bonus.Data.Repositories
{
    public abstract class RepositoryBase<TEntity>: IRepositoryBase<TEntity>
        where TEntity : class
    {
        private readonly ApplicationDbContext context;

        public RepositoryBase(ApplicationDbContext context) =>
            this.context = context;

        public async Task<IEnumerable<TEntity>> GetAllAsync() =>
            await context.Set<TEntity>().ToListAsync();

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }
        
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();
            return entity;
        }
        
    }
}