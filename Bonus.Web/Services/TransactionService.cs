using System.Threading.Tasks;
using Bonus.Data.Models;

namespace Bonus.Web.Services
{
    public class TransactionService:ITransactionService
    {
        public async Task<Transaction> Commit(Transaction transaction)
        { 
            throw new System.NotImplementedException();
        }
    }
}