/*multidimensional array
    array having multiple values
   syntax public string[,] Time


jagged array array inside array:
    syntax public string[] [] Time
foreach loop
 
 */


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

            BusTimes times5 = repository.BusTimeRoute5;
            BusRoute route5 = times5.Route;


            //for(int iPlace = 0; iPlace < route5.PlacesServed.Length; iPlace++)
            //{
            //    Console.Write(route5.PlacesServed[iPlace]+ "  ");

            //    for(int iPlaceTime=0;iPlaceTime < times5.Times.GetLength(1); iPlaceTime++)
            //    {
            //        Console.Write(times5.Times[iPlace,iPlaceTime]+" ");
            //    }
            //    Console.WriteLine();
            //}

            for (int iPlace = 0; iPlace < route5.PlacesServed.Length; iPlace++)
            {
                Console.Write(route5.PlacesServed[iPlace] + "  ");

                foreach (string time in times5.Times[iPlace])
                {
                    Console.Write(time+" ");
                }
                Console.WriteLine();
            }


        }
    }
}
