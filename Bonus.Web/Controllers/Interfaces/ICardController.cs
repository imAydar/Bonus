using System.Threading.Tasks;
using Bonus.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bonus.Web.Controllers
{
    public interface ICardController : IControllerBase<Card>
    {
        Task<IActionResult> GetByCode(string code);
        Task<IActionResult> GetBonusSumm(int cardId);
    }
}