using System.Collections.Generic;
using System.Threading.Tasks;
using Bonus.Data.Models;
using Bonus.Data.Repositories;

namespace Bonus.Web.Services
{
    public class CardService : BaseService<Card>, ICardService
    {
        readonly ICardRepository cardRepository;
        
        public CardService(ICardRepository cardRepository) :base(cardRepository)
        {
            this.cardRepository = cardRepository;
        }

        public async Task<Card> GetByCodeAsync(string code)
        {
            return await cardRepository.GetByCode(code);
        }
    }
}