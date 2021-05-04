using HospitalInformationSystem.Shared.Filters.Interfaces;
using HospitalInformationSystem.Shared.UnitOfWorks.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalInformationSystem.API.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ControllerBase<T, Filter> : ControllerBase where T : class where Filter : IFilter<T>
    {
        private readonly IUnitOfWork<T> _uow;

        public ControllerBase(IUnitOfWork<T> uow)
        {
            _uow = uow;
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<T>>> Get()
        {
            try
            {
                return Ok(await _uow.Repository.Get());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data");
            }
        }

        [HttpGet("search")]
        public virtual async Task<ActionResult<IEnumerable<T>>> Get([FromQuery] Filter filter, [FromHeader] bool usePagination = true)
        {
            try
            {
                return Ok(await _uow.Repository.Get(filter, usePagination));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data");
            }
        }

        [HttpGet("{id:Guid}")]
        public virtual async Task<ActionResult<T>> Get(Guid id)
        {
            try
            {
                var entity = await _uow.Repository.Get(id);

                return (entity == null) ?
                    NotFound($"{typeof(T).Name} with Id = {id} not found!") : Ok(entity);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data");
            }
        }

        [HttpPost]
        public virtual async Task<ActionResult<T>> Post([FromBody] T entity)
        {
            try
            {
                if (entity == null)
                    return BadRequest($"The {typeof(T).Name} cannot null!");

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var added = await _uow.Repository.Add(entity);

                return (await _uow.Save() == 1) ?
                    Ok(added) : BadRequest(entity);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error adding data");
            }
        }

        [HttpPut]
        public virtual async Task<ActionResult<T>> Put([FromBody] T entity)
        {
            try
            {
                if (entity == null)
                    BadRequest($"The {typeof(T).Name} cannot null!");

                if (!ModelState.IsValid)
                    BadRequest(ModelState);

                var updated = await _uow.Repository.Update(entity);

                return (await _uow.Save() == 1) ?
                    Ok(updated) : BadRequest(updated);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating data");
            }
        }

        [HttpDelete("{id:Guid}")]
        public virtual async Task<ActionResult<T>> Delete(Guid id)
        {
            try
            {
                var deleted = await _uow.Repository.Delete(id);

                return (await _uow.Save() == 1) ?
                    Ok(deleted) : BadRequest(deleted);
            }
            catch
            {
                return ((await _uow.Repository.Get(id)) == null) ?
                    NotFound($"{typeof(T).Name} with Id = {id} not found!") :
                    StatusCode(StatusCodes.Status500InternalServerError, "Error deleting data");
            }
        }
    }
}