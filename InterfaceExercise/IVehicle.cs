using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int HasTires { get; set; }

        public string HasFuel { get; set; }

        public double EngineSize { get; set; }

        public int HoldsPassengers { get; set; }

        public void Drive();

        public void Reverse();

        public void Park();
    }
}
