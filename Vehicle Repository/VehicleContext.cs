using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Vehicle_Repository
{
    public class VehicleContext:DbContext
    {
        public VehicleContext() : base("name=VehicleConnectionString") { }
        public DbSet<Vehicle> Vehicles { get; set; }

    }
}
