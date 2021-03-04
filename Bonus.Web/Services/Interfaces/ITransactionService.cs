using System.Threading.Tasks;
using Bonus.Data.Models;

namespace Bonus.Web.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITransactionService
    {
        Task<Transaction> Commit(Transaction transaction);
    }
}