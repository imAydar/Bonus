using System.Threading.Tasks;
using Bonus.Core.Services;
using Bonus.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bonus.Web.Controllers
{
    [ApiController]
    [Route("transaction")]
    public class TransactionController : Microsoft.AspNetCore.Mvc.ControllerBase, ITransationController
    {
        private readonly TransactionService service;

        public TransactionController(TransactionService service)
        {
            this.service = service;
        }
        
        [HttpPost]
        public async Task<IActionResult> Commit(Transaction transaction)
        {
            return Ok(await service.Commit(transaction));
        }
    }
}