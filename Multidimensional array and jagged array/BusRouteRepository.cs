using System;
using System.Runtime.CompilerServices;

namespace BusRouteApplication
{
    public class BusRouteRepository
    {
        private readonly BusRoute[] _allRoutes;
        public BusTimes BusTimeRoute5 { get; }
        

        public BusRouteRepository()
        {
            _allRoutes = new BusRoute[] {
                new BusRoute(40, new string[] { "Morcambe", "Lancaster", "Garstang", "Preston","Carnforth" }),
                new BusRoute(42, new string[] { "Lancaster", "Garstang", "Blackpool" }),
                new BusRoute(100, new string[] { "University", "Lancaster", "Morecambe" }),
                new BusRoute(555, new string[] { "Lancaster", "Carnforth", "Kendel", "Windermere", "Keswik" }),
                new BusRoute(5, new string[] { "Overton", "Morcambe", "Carnforth" })
            };

            //multidimensional array
            //string[,] timesRoute5 ={
            //    {"15:40","16:40","17:40","18:40"},              
            //    {"16:09","17:00","18:40","19:40"},
            //    {"16:40","17:50","19:00","20:05"}

            //};
           // BusTimeRoute5 = new BusTimes(Array.Find(_allRoutes, x => x.Number == 5), timesRoute5);

            string[][] timesRoute5 ={
                new string[ ]{"15:40","16:40","17:40","18:40"},
                new string[ ]{"16:09","17:00","18:40","19:40"},
                new string[ ]{"16:40","17:50","19:00" }
       
            };
             BusTimeRoute5 = new BusTimes(Array.Find(_allRoutes, x => x.Number == 5), timesRoute5);

        }
    }
}
