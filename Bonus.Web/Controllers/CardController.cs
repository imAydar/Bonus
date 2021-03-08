using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bonus.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Bonus.Data.Models;
using Microsoft.Extensions.Logging;

namespace Bonus.Web.Controllers
{

    /// <summary>
    /// simple crud controller
    /// </summary>
    [ApiController]
    [Route("card")]
    public class CardController :  Bonus.Web.Controllers.ControllerBase<Card>, ICardController
    {
        private readonly ICardService cardService;
        private readonly ILogger<CardController> logger;

        public CardController(ICardService cardService, ILogger<CardController> logger) : base(cardService)
        {
            this.cardService = cardService;
            this.logger = logger;
        }
        
        public async override Task<IActionResult> Get()
        {
            try
            {
                var result = await cardService.GetAllAsync();
                logger.LogCritical("got");
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetByCode(string code)
        {
            try
            {
                var result = await cardService.GetByCodeAsync(code);
                logger.LogCritical("code");
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("getbonus/{cardId}")]
        public async Task<IActionResult> GetBonusSumm(int cardId)
        {
            return Ok(cardService.GetCurrentBonusAmount(cardId) as object);
        }
    }
}