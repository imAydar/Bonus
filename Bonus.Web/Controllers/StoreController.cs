using Bonus.Core.Services.Interfaces;
using Bonus.Data.Models;
using Bonus.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Bonus.Web.Controllers
{
    [ApiController]
    [Route("store")]
    public class StoreController:Bonus.Web.Controllers.ControllerBase<Store>, IStoreController
    {
        private readonly IStoreService service;

        public StoreController(IStoreService service) : base(service) =>
            this.service = service;
    }
}