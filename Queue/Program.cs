using SimulateJourney;

using System;

namespace SimulateJourney
{
    public class Program
    {
        public static void Main()
        {
           BusStop busstop=new BusStop();
           Bus bus = new Bus();

            for(int i = 0; i < 6; i++)
            {
                busstop.PersonArrive(PassengerGenerator.CreatePassenger());
            }
            busstop.BusArrive(bus);
        }
    }
}