using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bonus.Web.Services;
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
        private readonly ICardService cardService;

        public CardController(ICardService cardService) : base(cardService)
        {
            this.cardService = cardService;
        }
        

        [HttpGet("{code}")]
        public async Task<IActionResult> Get(string code)
        {
            try
            {
                var result = await cardService.GetByCodeAsync(code);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
/*
        [HttpPost]
        public async Task<IActionResult> Create(Card card)
        {
            try
            {
                var result = await cardService.CreateAsync(card);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Card card)
        {
            try
            {
                var result = await cardService.UpdateAsync(card);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Card card)
        {
            try
            {
                var result = await cardService.DeleteAsync(card);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }*/
    }
}