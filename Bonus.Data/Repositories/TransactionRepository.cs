using System;
using System.Linq;
using Bonus.Data.Models;

namespace Bonus.Data.Repositories
{
    public class TransactionRepository: ITransactionRepository
    {
        private readonly ApplicationDbContext context;

        public TransactionRepository(ApplicationDbContext context) =>
            this.context = context;

        public Transaction Commit(Transaction transaction)
        {
            context.Transactions.Add(transaction);
            context.SaveChanges();
            return transaction;
        }

        
    }
}