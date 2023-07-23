using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public string Logo { get; set; } = "Nissan";
        public bool Import { get; set; } = true;
        public int HasTires { get; set; } = 4;
        public string HasFuel { get; set; } = "That jet fuel should work.";
        public double EngineSize { get; set; } = 2.5;
        public int HoldsPassengers { get; set; } = 2;

        public double Mpg { get; set; } = 18.5;
        public bool CanDrift { get; set; } = true;
        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is driving on the highway.");
        }

        public void Park()
        {
            Console.WriteLine($"{GetType().Name} is parked."); ;
        }

        public void Reverse()
        {
            Console.WriteLine($"{GetType().Name} is in reverse.");
        }
    }
}
