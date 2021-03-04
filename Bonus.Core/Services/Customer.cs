using Bonus.Core.Services.Interfaces;
using Bonus.Data.Models;
using Bonus.Data.Repositories;

namespace Bonus.Core.Services
{
    public class Customer:ServiceBase<Data.Models.Customer>, ICustomer
    {
        private readonly ICustomerRepository repository;

        public Customer(ICustomerRepository repository):base(repository) =>
            this.repository = repository;
    }
}