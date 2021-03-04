using Bonus.Core.Services.Interfaces;
using Bonus.Data.Models;
using Bonus.Data.Repositories;

namespace Bonus.Core.Services
{
    public class Store:ServiceBase<Data.Models.Store>, IStore
    {
        private readonly IStoreRepository repository;

        public Store(IStoreRepository repository):base(repository) =>
            this.repository = repository;
    }
}