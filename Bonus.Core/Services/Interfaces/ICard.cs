using System.Threading.Tasks;
using Bonus.Data.Models;

namespace Bonus.Core.Services.Interfaces
{
    public interface ICard : IServiceBase<Data.Models.Card>
    {
        public Task<Data.Models.Card> GetByCodeAsync(string code);
    }
}