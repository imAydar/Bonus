using System;
using System.Threading.Tasks;
using Bonus.Core.Services.Interfaces;
using Bonus.Data.Models;
using Bonus.Data.Repositories;

namespace Bonus.Core.Services
{
    public class CardService : BaseService<Card>, ICardService
    {
        readonly ICardRepository cardRepository;
        
        public CardService(ICardRepository cardRepository) :base(cardRepository) =>
            this.cardRepository = cardRepository;

        public async Task<Card> GetByCodeAsync(string code) =>
            await cardRepository.GetByCode(code);

        public decimal GetCurrentBonusAmount(int cardId)
        {
            return cardRepository.GetBonus(cardId);
        }
    }
}