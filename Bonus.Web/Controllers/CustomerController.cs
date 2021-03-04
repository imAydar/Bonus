using Bonus.Core.Services.Interfaces;
using Bonus.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bonus.Web.Controllers
{
    /// <summary>
    /// simple crud controller
    /// </summary>
    [ApiController]
    [Route("customer")]
    public class CustomerController:  Bonus.Web.Controllers.ControllerBase<Customer>, ICustomerController
    {
        private readonly ICustomer service;

        public CustomerController(ICustomer service) : base(service)
        {
            this.service = service;
        }
    }
}