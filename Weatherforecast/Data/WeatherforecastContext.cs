using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Weatherforecast;

namespace Weatherforecast.Data
{
    public class WeatherforecastContext : DbContext
    {
        public WeatherforecastContext (DbContextOptions<WeatherforecastContext> options)
            : base(options)
        {
        }

        public DbSet<Weatherforecast.Student> Student { get; set; }
    }
}
