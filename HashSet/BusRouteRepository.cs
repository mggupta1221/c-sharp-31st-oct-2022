using System;


namespace BusRouteApplication
{
    public class BusRouteRepository
    {
        private readonly BusRoute[] _allRoutes;

        public BusRouteRepository()
        {
            _allRoutes = new BusRoute[] {
                new BusRoute(40, new string[] { "Morcambe", "Lancaster", "Garstang", "Preston","Carnforth" }),
                new BusRoute(42, new string[] { "Lancaster", "Garstang", "Blackpool" }),
                new BusRoute(100, new string[] { "University", "Lancaster", "Morecambe" }),
                new BusRoute(555, new string[] { "Lancaster", "Carnforth", "Kendel", "Windermere", "Keswik" }),
                new BusRoute(5, new string[] { "Overton", "Morcambe", "Carnforth" })
            };
        }
   


        public BusRoute[] FindBusesTo(string location )
        {
            return Array.FindAll(_allRoutes, route => route.Serves(location));
        }

        public BusRoute[] FindBusesBetween(string location1,string location2)
        {
            return Array.FindAll(_allRoutes, route => (route.Serves(location1) &&  route.Serves(location2)));
        }
    }
}
