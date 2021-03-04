using System;

namespace Bonus.Data.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime ChequeTime { get; set; }
        public string ChequeNumber { get; set; }
        public Decimal Summ { get; set; }
        public Decimal? Bonus { get; set; }
        
        public int TerminalId { get; set; }
        public Terminal Terminal { get; set; }


        public int CardId { get; set; }
        public Card Card { get; set; }
        //public int? UserID{get;set;}//can get it from card table;
    }
}