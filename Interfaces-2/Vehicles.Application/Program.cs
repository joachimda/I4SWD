using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("::::::::GasEngine::::::::");
            IEngine myGasEngine = new GasEngine(10);
            MotorBike myGasBike = new MotorBike(myGasEngine);
            System.Console.WriteLine("Run at half speed.");
            myGasBike.RunAtHalfSpeed();

            System.Console.WriteLine("::::::::DieselEngine:::::");
            IEngine myDieEngine = new DieselEngine(20);
            MotorBike myDieselBike = new MotorBike(myDieEngine);
            System.Console.WriteLine("Run at half speed.");
            myDieselBike.RunAtHalfSpeed();
        }
    }
}
