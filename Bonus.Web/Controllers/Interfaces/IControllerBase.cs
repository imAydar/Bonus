using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bonus.Web.Controllers
{
    public interface IControllerBase<TEntity>
        where TEntity : class
    {
        Task<IActionResult> Get();
        Task<IActionResult> Create(TEntity entity);
        Task<IActionResult> Update(TEntity entity);
        Task<IActionResult> Delete(TEntity entity);
    }
}