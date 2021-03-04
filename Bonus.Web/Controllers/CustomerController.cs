using Bonus.Data.Models;
using Bonus.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bonus.Web.Controllers
{
    /// <summary>
    /// simple crud controller
    /// </summary>
    [ApiController]
    [Route("user")]
    public class CustomerController:  Bonus.Web.Controllers.ControllerBase<Customer>, ICustomerController
    {
        private readonly ICustomerService service;

        public CustomerController(ICustomerService service) : base(service)
        {
            this.service = service;
        }
    }
}