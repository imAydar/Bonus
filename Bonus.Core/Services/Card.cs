using System.Threading.Tasks;
using Bonus.Core.Services.Interfaces;
using Bonus.Data.Models;
using Bonus.Data.Repositories;

namespace Bonus.Core.Services
{
    public class Card : ServiceBase<Data.Models.Card>, ICard
    {
        readonly ICardRepository cardRepository;
        
        public Card(ICardRepository cardRepository) :base(cardRepository) =>
            this.cardRepository = cardRepository;

        public async Task<Data.Models.Card> GetByCodeAsync(string code) =>
            await cardRepository.GetByCode(code);
    }
}