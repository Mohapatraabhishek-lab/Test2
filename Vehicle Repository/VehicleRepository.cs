using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        
        public double CalculateRepairCost(string defectType)
        {
            double cost = 0;
            if (defectType == "Tyre")
                cost = 17000;
            else if (defectType == "Fuel System")
                cost = 15000;
            else if (defectType == "Engine")
                cost = 20000;
            else if (defectType == "Break System")
                cost = 8000;
            return cost;
        }

        public bool checkDefectType(string defectType)
        {
            List<string> defectList=new List<string>();
            defectList.Add("Tyre");
            defectList.Add("Fuel System");
            defectList.Add("Engine");
            defectList.Add("Break System");
            bool res = true;
            if(defectList.Contains(defectType))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }

        public List<Vehicle> GetVehicleByStatus(string status)
        {
            var context = new VehicleContext();
            var con = context.Vehicles.Where(v => v.Status == status).ToList();
            List<Vehicle> vehicleList = new List<Vehicle>();
            foreach(var c in con)
            {
                vehicleList.Add(c);
            }
            return vehicleList;
        }
        public List<Vehicle> GetVehicles()
        {
            var context = new VehicleContext();
            var con = context.Vehicles;
            List<Vehicle> l1=new List<Vehicle>();
            foreach(var c in con)
            {
                l1.Add(c);
            }
            return l1;
        }

        public Vehicle UpdateRepairStatus(int VehicleId, string Status)
        {
            var context = new VehicleContext();
            var con = context.Vehicles.Where(v => v.VehicleId == VehicleId).FirstOrDefault<Vehicle>();
            con.Status = Status;
            context.SaveChanges();
            return con;
        }

        public Vehicle VehicleCheckIn(Vehicle v)
        {
            var context = new VehicleContext();
            context.Vehicles.Add(v);
            context.SaveChanges();
            //Console.WriteLine("Vehicle Inserted Successfully");
            return v;
           
        }
    }
}
