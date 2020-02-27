using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineCharacteristics
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("CalculationResultsDatabase")
        {
        }

        public DbSet <Result> Results { get; set; }
    }
}
