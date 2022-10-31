using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SimulateJourney
{
    public class BusStop
    {
        private Queue<Passenger> _personWaiting=new Queue<Passenger>();

        public void BusArrive(Bus bus)
        {
            Console.WriteLine();
            Console.WriteLine($"Bus arriving at bus stop to pick passengers");
            while(bus.Space >0 && _personWaiting.Count > 0)
            {
                Passenger passenger =_personWaiting.Dequeue(); //return dequeued item
                bus.Load(passenger);
            }
        }

        public void PersonArrive(Passenger person)
        {
            _personWaiting.Enqueue(person);
            Console.WriteLine($"{person} Queuing at Bus Stop");
        }




    }
}
