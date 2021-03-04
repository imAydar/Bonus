using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bonus.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Bonus.Data.Models;

namespace Bonus.Web.Controllers
{

    /// <summary>
    /// simple crud controller
    /// </summary>
    [ApiController]
    [Route("card")]
    public class CardController :  Bonus.Web.Controllers.ControllerBase<Card>, ICardController
    {
        private readonly ICard _card;

        public CardController(ICard card) : base(card) =>
            this._card = card;


        [HttpGet("{code}")]
        public async Task<IActionResult> Get(string code)
        {
            try
            {
                var result = await _card.GetByCodeAsync(code);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}