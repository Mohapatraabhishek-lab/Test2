using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Repository
{
    public interface IVehicleRepository
    {
        Boolean checkDefectType(string defectType);
        double CalculateRepairCost(string defectType);
        Vehicle VehicleCheckIn(Vehicle v);
        List<Vehicle> GetVehicles();
        List<Vehicle> GetVehicleByStatus(string Status);
        Vehicle UpdateRepairStatus(int VehicleId, string Status);
        
    }
}
