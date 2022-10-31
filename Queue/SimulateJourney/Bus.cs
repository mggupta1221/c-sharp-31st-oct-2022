using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateJourney
{
    public class Bus
    {
        public const int CAPACITY = 5;
        public int Space { get { return CAPACITY - _passengers.Count; } }

        private List <Passenger> _passengers=new List<Passenger>();

        public bool Load(Passenger passenger)
        {
            if (Space < 1)
                return false;

           _passengers.Add(passenger);
            Console.WriteLine($"{passenger} got on Bus");
            return true;
        }
    }
}
