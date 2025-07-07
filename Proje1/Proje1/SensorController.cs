using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proje1.Data.Contexts;

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
        


    }
}
