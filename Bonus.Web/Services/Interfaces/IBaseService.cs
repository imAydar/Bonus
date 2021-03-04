using System.Collections.Generic;
using System.Threading.Tasks;
using Bonus.Data.Models;

namespace Bonus.Web.Services
{
    public interface IBaseService<TEntity> 
        where TEntity : class
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(TEntity entity);
    }
}