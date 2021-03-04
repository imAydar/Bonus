using System.ComponentModel.DataAnnotations.Schema;

namespace Bonus.Data.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int UserId { get; set; }
        public decimal Balance { get; }

        [NotMapped]
        public decimal BonusRate//mb change to new class CardDTO without BonusRate
        {
            get { return 0.05M; }
        }
    }

}