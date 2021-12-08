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
    public class BuildingsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public BuildingsController(ApplicationContext context) 
        {
            _context = context;
        }

        public Building buildingsFindById(long Id, List<Building> listBuilding) 
        {
            foreach (Building building in listBuilding) 
            {
                if (building.id == Id) 
                {
                    return building;
                }
            }
            return null;
        }

        

        [HttpGet]
        public List<Building> GetBuildings()
        {
            var buildings = _context.buildings.ToList();
            var batteries = _context.batteries.ToList();
            var columns = _context.columns.ToList();
            var elevators = _context.elevators.ToList();

            var filteredBatteries = batteries.Where(battety => battety.status == "intervention").ToList();
            var filteredColumns = columns.Where(column => column.status == "intervention").ToList();
            var filteredElevators = elevators.Where(elevator => elevator.status == "intervention").ToList();

            List<Building> result = new List<Building>();
            foreach (Battery battery in filteredBatteries) 
            {
                var containerBuilding = buildingsFindById(battery.building_id, buildings);
                if (containerBuilding != null && battery.getColumnList(filteredColumns, filteredElevators) && !result.Contains(containerBuilding)) 
                {
                    result.Add(containerBuilding);
                }
            }
            return result;
        }
    }  
}
