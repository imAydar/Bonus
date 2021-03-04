using System.Collections.Generic;
using System.Threading.Tasks;
using Bonus.Data.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Bonus.Data.Repositories
{
    public class CardRepository : RepositoryBase<Card>, ICardRepository
    {
        private readonly ApplicationDbContext context;
        
        public CardRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
            if(! context.Cards.Any())
            {
                context.Cards.Add(new Card(){
                    Id = 1,
                    Code = "9785132"
                });
                context.SaveChanges();
            }
        }
        
        public async Task<Card> GetByCode(string code)
        {
            return await context.Cards.FirstAsync(x => x.Code == code);
        }
    }
}