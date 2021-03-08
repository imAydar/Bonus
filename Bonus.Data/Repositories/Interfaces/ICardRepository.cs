using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Bonus.Data.Models;

namespace Bonus.Data.Repositories
{
    public interface ICardRepository: IRepositoryBase<Card>
    {
        Task<Card> GetByCode(string code);
        decimal GetBonus(int cardId);
        decimal GetBonusRate(int cardId);
    }
}