using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles.Models.Interfaces
{
    public interface IVehicle
    {
        
        string Drive(double distance);

        void Refuel(double liters);

    }
}
