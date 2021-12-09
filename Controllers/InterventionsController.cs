using System;
using System.Data;
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

    public class InterventionsController : ControllerBase
    {
        private readonly ApplicationContext _context;


        public InterventionsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET api/get-pendings
        [HttpGet("get-pendings")]
        public async Task<ActionResult<List<Intervention>>> GetInterventions()
        {
            return await _context.interventions.Where(i => (i.status == "Pending" && i.start_intervention == null)).ToListAsync();
            //List<Intervention> allInterventions = _context.interventions.ToList();
            //List<Intervention> pendings = allInterventions.Where(intervention => (intervention.status == "pending" && intervention.start_intervention == null)).ToList();
            //List<Intervention> noTime = pendings.Where(intervention => ).ToList();
            //return noTime;
            //return pendings;
        }
        /*
        public List<Intervention> GetInterventions()
        {
            List<Intervention> allInterventions = _context.interventions.ToList();
            List<Intervention> pendings = allInterventions.Where(intervention => (intervention.status == "pending" && intervention.start_intervention == null)).ToList();
            //List<Intervention> noTime = pendings.Where(intervention => ).ToList();
            //return noTime;
            return pendings;
        }
                [HttpPut("start/{id}")]
        public Intervention start(long id)
        {
            var intervention =  _context.interventions.Find(id);
            intervention.start_intervention = DateTime.Now;
            intervention.status = "inProgrss";
            _context.SaveChanges();         
            return intervention;
        }
        */


        [HttpPut("start/{id}")]
        public async Task<ActionResult<Intervention>> ChangeToInProgress(long id, Intervention inter)
        {
            var intervention = await _context.interventions.FindAsync(id);
            intervention.start_intervention = DateTime.Now;
            intervention.status = inter.status;
            try {
                await _context.SaveChangesAsync();         
            } catch {
                throw;
            }
            
            return intervention;
        }

        [HttpPut("end/{id}")]
        public async Task<ActionResult<Intervention>> ChangeToComplete(long id, Intervention inter)
        {
             var intervention = await _context.interventions.FindAsync(id);
            intervention.end_intervention = DateTime.Now;
            intervention.status = inter.status;
                await _context.SaveChangesAsync();         

            return intervention;
        }
    }
}
