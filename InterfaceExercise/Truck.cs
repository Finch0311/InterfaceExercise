using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle , ICompany
    {
        public string Logo { get; set; } = "Ford";
        public bool Import { get; set; } = false;
        public int HasTires { get; set; } = 4;
        public string HasFuel { get; set; } = "Just throw some 110 proof in there.";
        public double EngineSize { get; set; } = 6.0;
        public int HoldsPassengers { get; set; } = 3;

        public string CanMud { get; set; } = "Lets get dirty.";

        public bool CanTow { get; set; } = true;

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is driving in 4 wheel drive on dirt road.");
        }

        public void Park()
        {
            Console.WriteLine($"{GetType().Name} is parked on hill");
        }

        public void Reverse()
        {
            Console.WriteLine($"{GetType().Name} goes really slow in reverse.");
        }
    }
}
