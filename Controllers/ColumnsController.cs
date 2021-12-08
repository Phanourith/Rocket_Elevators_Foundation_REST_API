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
    public class ColumnsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ColumnsController(ApplicationContext context) 
        {
            _context = context;
        }

        [HttpGet("{id}/status")]
        public async Task<ActionResult<string>> GetColumnStatus(long id)
        {
            var column = await _context.columns.FindAsync(id);
            if (column == null)
            {
                return NotFound();
            }
            return column.Status;
        }

        [HttpGet("update/{id}/{status}")]
        public async Task<dynamic> UpdateColumnStatus(string status, long id)
        {
            var column = await _context.columns.FindAsync(id);
            
            column.Status = status;
            await _context.SaveChangesAsync();         

            return column;
        }

        [HttpGet("all")]
        public List<Column> GetAllColumns(string status, long id)
        {
            var columns = _context.columns.ToList();
            return columns;
        }
    }  
}
