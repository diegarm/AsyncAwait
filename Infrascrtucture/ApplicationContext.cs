using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait.Infrascrtucture
{
    public class ApplicationContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecast { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:diegonpp.database.windows.net,1433;Initial Catalog=Eventos;Persist Security Info=False;User ID=useradmin;Password=Diegobento@21;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

    }
}
