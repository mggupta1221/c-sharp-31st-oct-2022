using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRouteApplication
{
    public class BusTimes
    {


      //  public string[,] Times { get; } //for  multidimensional array
         
        public string[] []Times { get; }  //jagged array
        public BusRoute Route { get; }
        public BusTimes(BusRoute Route, string[] []times)
        {
            this.Route = Route;
            this.Times = times;
        }
    }
}