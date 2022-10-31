using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateJourney
{
    public class PassengerGenerator
    {
        private static int _count=0;

        public static Passenger CreatePassenger()
        {
            string Destination = "Lancaster";
            return new Passenger($"Person {++ _count}", Destination);
        }
    }
}
