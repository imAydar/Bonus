using Bonus.Data.Models;

namespace Bonus.Data.Repositories
{
    public interface ITransactionRepository
    {
        Transaction Commit(Transaction transaction);
        
    }
}