using System;
using Microsoft.EntityFrameworkCore;

namespace Bonus.Data.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime ChequeTime { get;  }
        public string ChequeNumber { get;  }
        public Decimal Summ { get;  }
        public Decimal Bonus { get; set; }
        public decimal BonusRateSoFar { get; set; }

        public int TerminalId { get; set; }
        public Terminal Terminal { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
        //public int? UserID{get;set;}//can get it from card table;
        
        protected static void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.Entity<Transaction>().Property(b => b.Id).UseIdentityAlwaysColumn();
    }
}