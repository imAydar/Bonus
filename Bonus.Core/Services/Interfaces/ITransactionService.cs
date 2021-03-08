using System.Threading.Tasks;
using Bonus.Data.DTOs;
using Bonus.Data.Models;

namespace Bonus.Core.Services.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITransactionService
    {
        Task<Transaction> Commit(TransactionDTO transactionDto);
        
    }
}