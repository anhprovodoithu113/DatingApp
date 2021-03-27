using DatingApp2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp2.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private DatingAppDbContext _context;
        public ValuesController(DatingAppDbContext context)
        {
            _context = context;
        }

        // Get api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();

            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(m => m.Id.Equals(id));

            return Ok(value);
        }
    }
}
