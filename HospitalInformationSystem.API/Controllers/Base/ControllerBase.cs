using HospitalInformationSystem.Shared.Filters.Interfaces;
using HospitalInformationSystem.Shared.UnitOfWorks.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<ActionResult<IEnumerable<T>>> Get()
        {
            try
            {
                var entities = await _uow.Repository.Get();

                if (entities == null || !entities.Any())
                    return NotFound($"No any {typeof(T).Name} found!");

                return Ok(entities);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data");
            }
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<T>>> Get([FromQuery] Filter filter)
        {
            try
            {
                var entities = await _uow.Repository.Get(filter);

                if (entities == null || !entities.Any())
                    return NotFound($"Any {typeof(T).Name} with these attributes was not found!");

                return Ok(entities);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data");
            }
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<T>> Get(Guid id)
        {
            try
            {
                var entity = await _uow.Repository.Get(id);

                if (entity == null)
                    return NotFound($"{typeof(T).Name} with Id = {id} not found!");

                return Ok(entity);
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
                return await _uow.Save() == 1 ? Ok(added)/*CreatedAtAction(nameof(Get), new { id = added.Id }, added.Id)*/ : BadRequest(entity);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error adding data");
            }
        }

        [HttpPut]
        public async Task<ActionResult<T>> Put([FromBody] T entity)
        {
            try
            {
                if (entity == null)
                    BadRequest($"The {typeof(T).Name} cannot null!");

                if (!ModelState.IsValid)
                    BadRequest(ModelState);

                var updated = await _uow.Repository.Update(entity);
                return await _uow.Save() == 1 ? Ok(updated) : BadRequest(updated);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating data");
            }
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<T>> Delete(Guid id)
        {
            try
            {
                var deleted = await _uow.Repository.Delete(id);

                if (deleted == null)
                    return NotFound($"{typeof(T).Name} with Id = {id} not found!");

                return await _uow.Save() == 1 ? Ok(deleted) : BadRequest(deleted);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting data");
            }
        }
    }
}