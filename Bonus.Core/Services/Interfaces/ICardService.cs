using System.Threading.Tasks;
using Bonus.Data.Models;

namespace Bonus.Core.Services.Interfaces
{
    public interface ICardService : IBaseService<Card>
    {
        public Task<Card> GetByCodeAsync(string code);
        public decimal GetCurrentBonusAmount(int cardId);
    }
}