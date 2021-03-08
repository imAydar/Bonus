using System.Threading.Tasks;
using Bonus.Data.DTOs;
using Bonus.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bonus.Web.Controllers
{
    public interface ITransationController
    {
        Task<IActionResult> Commit(TransactionDTO transactionDto);
    }
}