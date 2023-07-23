using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public string Logo { get; set; } = "Chevy";
        public bool Import { get; set; } = false;
        public int HasTires { get; set; } = 4;
        public string HasFuel { get; set; } = "Hit the next gas station.";
        public double EngineSize { get; set; } = 5.7;
        public int HoldsPassengers { get; set; } = 6;

        public bool FuelEffienct { get; set; } = false;

        public string DVDs { get; set; } = "We have all the entertainment.";

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is driving now.");
        }

        public void Park()
        {
            Console.WriteLine($"{GetType().Name} has parked.");
        }

        public void Reverse()
        {
            Console.WriteLine($"{GetType().Name} is in reverse.");
        }
    }
}
