using Bonus.Core.Services.Interfaces;
using Bonus.Data.Models;
using Bonus.Data.Repositories;

namespace Bonus.Core.Services
{
    public class StoreService:BaseService<Store>, IStoreService
    {
        private readonly IStoreRepository repository;

        public StoreService(IStoreRepository repository):base(repository) =>
            this.repository = repository;
    }
}