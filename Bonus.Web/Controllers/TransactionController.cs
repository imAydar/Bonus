using System.Threading.Tasks;
using Bonus.Core.Services;
using Bonus.Core.Services.Interfaces;
using Bonus.Data.DTOs;
using Bonus.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bonus.Web.Controllers
{
    [ApiController]
    [Route("transaction")]
    public class TransactionController : Microsoft.AspNetCore.Mvc.ControllerBase, ITransationController
    {
        private readonly ITransactionService service;

        public TransactionController(ITransactionService service)
        {
            this.service = service;
        }
        
        [HttpPost]
        public async Task<IActionResult> Commit(TransactionDTO transactionDto)
        {
            return Ok(await service.Commit(transactionDto));
        }
    }
}