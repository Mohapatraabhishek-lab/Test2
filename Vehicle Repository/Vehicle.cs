using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Repository
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
        public string VehicleType { get; set; }
        public string Color { get; set; }
        public string DefectType { get; set; }
        public string Status { get; set; }
        //private double repairCost;
        public double RepairCost{ get; set; }   
    }
}
