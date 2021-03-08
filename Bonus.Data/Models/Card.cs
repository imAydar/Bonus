//using System.ComponentModel.DataAnnotations.Schema;

using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Bonus.Data.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? CustomerId { get; set; }
        [JsonIgnore]
        public Customer Customer { get; set; }

        public decimal Balance { get; }
        // [NotMapped]
        public decimal BonusRate//mb change to new class CardDTO without BonusRate
        {
            get { return 0.05M; }
        }

        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().Property(property => property.Code).HasMaxLength(13);
        }
    }

}