using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using RocketApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace RocketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElevatorsController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public ElevatorsController(ApplicationContext context)
        {
            _context = context;
        }
        [HttpGet("{all}")]
        public async Task<dynamic> GetAllElevators(){
            var elevators = await _context.elevators.ToListAsync();
            var i = 0;
            var numbers = new List<Int64>(){};
            
            foreach(Elevator elevator in elevators)
            {
                i++;
            }
            numbers.Add(i);
            return numbers;
        }
        [HttpGet("{id}/status")]
        public async Task<ActionResult<string>> GetElevatorStatus(long id)
        {
            var elevator = await _context.elevators.FindAsync(id);
            if (elevator == null)
            {
                return NotFound();
            }
            return elevator.status;
        }
       
        [HttpGet("Offline")]
        public object GetElevatorsOffline()
        {
            return _context.elevators
                  .Where(elevator => elevator.status == "offline" || elevator.status == "maintenance")
                  .Select(elevator => new { elevator.id, elevator.status });

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Elevator>>> getElevators()
        {
            return await _context.elevators.ToListAsync();
        }

        [HttpGet("update/{id}/{status}")]
        public async Task<dynamic> test(string status, long id)
        {
            var elevator = await _context.elevators.FindAsync(id);
            
            elevator.status = status;
            await _context.SaveChangesAsync();         

            return elevator;
        }
        
        
        
    }

}






        

  
