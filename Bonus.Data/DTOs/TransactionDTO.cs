using System;
using Bonus.Data.Models;

namespace Bonus.Data.DTOs
{
    public class TransactionDTO
    {
        public DateTime ChequeTime { get; set; }
        public string ChequeNumber { get; set; }
        public Decimal Summ { get; set; }

        public int TerminalId { get; set; }
        public Terminal Terminal { get; set; }
        
        public int CardId { get; set; }
        public Card Card { get; set; }
        //public int? UserID{get;set;}//can get 
    }
}