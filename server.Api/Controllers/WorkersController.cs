using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using server.Core.DTOs;
using Server.API.Models;
using Server.Core.Entities;
using Server.Core.IServices;
using Server.Service;
using System.Security.Principal;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkersController : ControllerBase
    {
        private readonly IWorkerService _IworkerService;
        private readonly IMapper _mapper;

        public WorkersController(IWorkerService IworkerService, IMapper mapper)
        {
            _IworkerService= IworkerService;
            _mapper=mapper;
        }
        //GET: api/<WorkersController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            Console.WriteLine("get");
            var workers =await _IworkerService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<WorkerDTO>>(workers));
        }

        // GET api/<WorkersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var worker = await _IworkerService.GetWorkerAsync(id);
            if (worker == null)
            {
                return NotFound();
            }

            return Ok(worker);
        }

        //POST api/<WorkersController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] WorkerPostModel worker)
        {
            Console.WriteLine("Add!!!");
            var workerToAdd = await _IworkerService.AddWorkerAsync(_mapper.Map<Worker>(worker));
            return Ok(_mapper.Map<Worker>(workerToAdd));
        }

        // PUT api/<WorkersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] WorkerPostModel worker)
        {
            var workerToUpdate = await _IworkerService.GetWorkerAsync(id);
            if (workerToUpdate == null)
            {
                return NotFound();
            }
            _mapper.Map(worker, workerToUpdate);
            workerToUpdate = await _IworkerService.UpdateWorkerAsync(id, workerToUpdate);

            return Ok(_mapper.Map<WorkerDTO>(workerToUpdate));
        }

        // DELETE api/<WorkersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Console.WriteLine("delete!!!");
            var worker = await _IworkerService.GetWorkerAsync(id);
            if (worker == null)
            {
                return NotFound();
            }
            await _IworkerService.DeleteWorkerAsync(id);
            return NoContent();
        }
    }
}
