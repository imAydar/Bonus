using Bonus.Core.Services.Interfaces;
using Bonus.Data.Models;
using Bonus.Data.Repositories;

namespace Bonus.Core.Services
{
    public class CustomerService:BaseService<Customer>, ICustomerService
    {
        private readonly ICustomerRepository repository;

        public CustomerService(ICustomerRepository repository):base(repository) =>
            this.repository = repository;
    }
}