using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Entities
{
    public class SensorData
    {
        [Key]
        public int Id { get; set; }
        public float sicaklik { get; set; }

        //public DateTime Timestamp { get; set; } = DateTime.UtcNow; 
    }
}
