using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proje1.Data.Contexts;
using Proje1.Entities;
using Microsoft.EntityFrameworkCore;

namespace Proje1
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorController : ControllerBase
    {
        private readonly Proje1DbContext _context;

   
    public SensorController(Proje1DbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostSensorData([FromBody] SensorData data)
        {
            if (data == null)
                return BadRequest("Veri boş");

            _context.SensorData.Add(data);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Veri kaydedildi" });
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSensorData()
        {
            var data = await _context.SensorData.ToListAsync();
            return Ok(data);
        }
    }
}
