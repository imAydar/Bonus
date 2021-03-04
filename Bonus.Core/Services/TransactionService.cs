using System.Threading.Tasks;
using Bonus.Core.Services.Interfaces;
using Bonus.Data.Models;

namespace Bonus.Core.Services
{
    public class TransactionService:ITransactionService
    {
        public async Task<Transaction> Commit(Transaction transaction)
        { 
            throw new System.NotImplementedException();
        }
    }
}