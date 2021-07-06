using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No of Vehicles needs to be Checked in");
            int num = Convert.ToInt32(Console.ReadLine());
            Vehicle v = new Vehicle();
            var context = new VehicleContext();
            VehicleRepository v1 = new VehicleRepository();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Name:");
                string vehicleName = Console.ReadLine();
                Console.WriteLine("Enter VehicleType:");
                string vehicleType = Console.ReadLine();
                Console.WriteLine("Enter Color:");
                string vehicleColor = Console.ReadLine();
                Console.WriteLine("Enter Defect Type");
                string defectType = Console.ReadLine();
                v.VehicleName = vehicleName;
                v.DefectType = defectType;
                v.Color = vehicleColor;
                v.VehicleType = vehicleType;
                if (v1.checkDefectType(defectType) == false)
                {
                    v.Status = "Rejected";
                }
                else
                {
                    v.Status = "Checked-In";
                }

                v.RepairCost = v1.CalculateRepairCost(defectType);
                v1.VehicleCheckIn(v);
                Console.WriteLine("Vehicles Inserted Successfully");
            }
            var l1 = v1.GetVehicles();
            foreach (var c in l1)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", c.VehicleId, c.VehicleName, c.VehicleType, c.Color,
                    c.DefectType, c.Status, c.RepairCost);
            }

            Console.WriteLine("Enter the Vehicle Id to Update");
            int id1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Status");
            string status = Console.ReadLine();
            v1.UpdateRepairStatus(id1, status);
            Console.WriteLine("Vehicles Updated Successfully");
            var goo = v1.GetVehicles().Find(t => t.VehicleId == id1);


            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", goo.VehicleId, goo.VehicleName, goo.VehicleType,
                goo.Color,
                goo.DefectType, goo.Status, goo.RepairCost);
            var l2 = v1.GetVehicles();
            foreach (var c in l2)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", c.VehicleId, c.VehicleName, c.VehicleType, c.Color,
                    c.DefectType, c.Status, c.RepairCost);
            }

            Console.WriteLine("Enter Status to get all the Vehicles");
            string status1 = Console.ReadLine();
            var output1 = v1.GetVehicleByStatus(status1);
            foreach (var r in output1)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", r.VehicleId, r.VehicleName, r.VehicleType, r.Color,
                    r.DefectType, r.Status, r.RepairCost);
            }
        }
    }
}
