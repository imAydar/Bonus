using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bonus.Data.Models;
using Bonus.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bonus.Web.Controllers
{
    public abstract class ControllerBase<TEntity> : ControllerBase, IControllerBase<TEntity>
        where TEntity : class
    {
        private readonly IBaseService<TEntity> serviceBase;

        public ControllerBase(IBaseService<TEntity> serviceBase)
        {
            this.serviceBase = serviceBase;
        }
        
        // GET
        [HttpGet]
        public async Task<IActionResult>  Get()
        {
            try
            {
                var result = await serviceBase.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(TEntity entity)
        {
            try
            {
                var result = await serviceBase.CreateAsync(entity);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(TEntity entity)
        {
            try
            {
                var result = await serviceBase.UpdateAsync(entity);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(TEntity entity)
        {
            try
            {
                var result = await serviceBase.DeleteAsync(entity);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}