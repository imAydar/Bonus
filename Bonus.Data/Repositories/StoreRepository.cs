using Bonus.Data.Models;

namespace Bonus.Data.Repositories
{
    public class StoreRepository:RepositoryBase<Store>,  IStoreRepository
    {
        private readonly ApplicationDbContext context;

        public StoreRepository(ApplicationDbContext context) : base(context) =>
            this.context = context;
    }
}