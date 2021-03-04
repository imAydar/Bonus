using Bonus.Data.Models;

namespace Bonus.Data.Repositories
{
    public class CustomerRepository: RepositoryBase<Customer>, ICustomerRepository
    {
        private readonly ApplicationDbContext context;
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}