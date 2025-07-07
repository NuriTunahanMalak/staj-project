using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proje1.Entities;

namespace Proje1.Data.Contexts
{
    public class Proje1DbContext : DbContext
    {
        public DbSet<SensorData> SensorData { get; set; }


        public Proje1DbContext(DbContextOptions<Proje1DbContext> options)
       : base(options) { } //Veritabanı bağlantı bilgilerini almak için
    }
}
