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

        private Stack <Passenger> _passengers=new Stack<Passenger>();

        public bool Load(Passenger passenger)
        {
            if (Space < 1)
                return false;

           _passengers.Push(passenger);
            Console.WriteLine($"{passenger} got on Bus");
            return true;
        }
        public void ArriveAtTerminus()
        {
            Console.WriteLine($"\n Bus Arriving At terminus");
            while(_passengers.Count > 0)
            {
                Passenger passenger = _passengers.Pop();
                Console.WriteLine($"{passenger} got off the bus");
            }
            Console.WriteLine($"There are still {_passengers.Count} passengers ");
        }

    }
}
