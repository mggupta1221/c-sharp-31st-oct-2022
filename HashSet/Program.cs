using System;
using System.Collections.Generic;//collections are provided

using System.Linq;
using System.Text;
using System.Threading.Tasks;
//need of List<> :array cannot remove the specific element at specific index
namespace BusRouteApplication
{
    public class Program
    {
        public static void Main()
        {
            BusRouteRepository repository = new BusRouteRepository();

            Console.WriteLine("Where Are u?");
            string startingAt = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Where do you want to go to?");
            string goingTo = Console.ReadLine();
            //BusRoute[] routes = repository.FindBusesBetween(startingAt, goingTo);

            BusRoute[] source = repository.FindBusesTo(startingAt);
            BusRoute[] destination=repository.FindBusesTo(goingTo);

            HashSet<BusRoute> routes = new HashSet<BusRoute>(source);
            routes.IntersectWith(destination);


            if (routes.Count>0)
                foreach (BusRoute route in routes)
                    Console.WriteLine($"You can use route {route}");
            else
                Console.WriteLine($"No routes go from {startingAt} to {goingTo}'");

        }         
    }
}
