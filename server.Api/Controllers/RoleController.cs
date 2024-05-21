using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using server.Api.Models;
using server.Core.DTOs;
using server.Core.IServices;
using Server.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _IroleService;
        private readonly IMapper _mapper;

        public RoleController(IRoleService IroleService, IMapper mapper)
        {
            _IroleService= IroleService;
            _mapper=mapper;
        }
        // GET: api/<JobController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var roles=await _IroleService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<RoleDTO>>(roles));
        }

        // GET api/<JobController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var role = await _IroleService.GetRoleAsync(id);
            if (role == null)
            {
                return NotFound();
            }

            return Ok(role);
        }

        // POST api/<JobController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] RolePostModel role)
        {
            var roleToAdd = await _IroleService.PostAsync(_mapper.Map<Role>(role));
            return Ok(_mapper.Map<Role>(roleToAdd));
        }

        // PUT api/<JobController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<JobController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var role = await _IroleService.GetRoleAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            await _IroleService.DeleteRoleAsync(id);
            return NoContent();
        }
    }
}
