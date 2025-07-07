using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proje1.Data.Contexts;
using Proje1.Entities;

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

        [HttpGet]
        public async Task<IActionResult> PostSensorData([FromBody] SensorData data)
        {
            if (data == null)
                return BadRequest("Veri boş");

           
  

            _context.SensorData.Add(data);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Veri kaydedildi" });
        }


    }
}
