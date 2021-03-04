using System.Collections.Generic;
using System.Threading.Tasks;
using Bonus.Data.Models;

namespace Bonus.Web.Services
{
    public interface ICardService : IBaseService<Card>
    {
        public Task<Card> GetByCodeAsync(string code);
    }
}