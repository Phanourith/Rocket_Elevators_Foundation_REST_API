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

    public class InterventionsController : ControllerBase
    {
        private readonly ApplicationContext _context;


        public InterventionsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Intervention> get()
        {
            List<Intervention> allInterventions = _context.interventions.ToList();
            List<Intervention> pendings = allInterventions.Where(intervention => intervention.Status == "pending").ToList();
            List<Intervention> noTime = pendings.Where(intervention => intervention.StartDateAndTime == null).ToList();
            return noTime;
        }

        [HttpPut("start/{id}")]
        public Intervention start(long id)
        {
            var intervention =  _context.interventions.Find(id);
            intervention.StartDateAndTime = DateTime.Now;
            intervention.Status = "inProgrss";
            _context.SaveChanges();         
            return intervention;
        }

        [HttpPut("end/{id}")]
        public Intervention end(long id)
        {
             var intervention =  _context.interventions.Find(id);
            intervention.EndDateAndTime = DateTime.Now;
            intervention.Status = "completed";
            _context.SaveChanges();         
            return intervention;
        }
    }
}
