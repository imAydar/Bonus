using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bonus.Core.Services.Interfaces;
using Bonus.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bonus.Web.Controllers
{
    public abstract class ControllerBase<TEntity> : ControllerBase, IControllerBase<TEntity>
        where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;
        public ControllerBase(IServiceBase<TEntity> serviceBase) =>
            this._serviceBase = serviceBase;

        [HttpGet]
        public async Task<IActionResult>  Get()
        {
            try
            {
                var result = await _serviceBase.GetAllAsync();
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
                var result = await _serviceBase.CreateAsync(entity);
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
                var result = await _serviceBase.UpdateAsync(entity);
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
                var result = await _serviceBase.DeleteAsync(entity);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}