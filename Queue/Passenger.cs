using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateJourney
{
    public class Passenger
    {

        public string Name { get; init; }
        public string Destination { get; init; }


        public Passenger(string Name, string Destination)
        {
            this.Name = Name;
            this.Destination = Destination;
        }
        public override string ToString()
        {
            return $"{Name} to {Destination}";
        }
    }
}
