using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using RocketApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace RocketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactInterventionsController : ControllerBase
    {
        private readonly ApplicationContext _context1;
        private readonly SecondApplicationContext _context2;


        public FactInterventionsController(ApplicationContext context1, SecondApplicationContext context2) 
        {
            _context1 = context1;
            _context2 = context2;
        }

        [HttpGet]
        public List<FactIntervention> Facts()
        {
            return _context2.fact_interventions.ToList();
        }

        [HttpGet("specificbuilding/{id}")]
        public Tuple<Building, List<FactIntervention>> getSpecificBuildingsWithBuildingID(int id)
        {
            var building = _context1.buildings.FirstOrDefault(a => a.id == id);
            IQueryable<FactIntervention> fact = _context2.fact_interventions.Where(a => a.building_id == id);
            List<FactIntervention> factlist = fact.ToList();
            return Tuple.Create(building,factlist);
        }

        [HttpGet("specificintervention/{id}")]
        public Tuple<FactIntervention,Building> getSpecificInterventions(int id)
        {
            FactIntervention fact = _context2.fact_interventions.FirstOrDefault(a => a.elevator_id == id);
            Building building = _context1.buildings.FirstOrDefault(a => a.id == fact.building_id);
            return Tuple.Create(fact,building);
        }
       
    }
}
