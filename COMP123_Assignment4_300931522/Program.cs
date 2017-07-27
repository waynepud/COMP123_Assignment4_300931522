using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Wayne Pud
 * Date: July 26, 2017
 * Description: Assignment 4 - Abstract planets
 * Version: 0.3 - Edited ToString object calls
 */

namespace COMP123_Assignment4_300931522
{
    /// <summary>
    /// This is the driver class which will create the new objects
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantplanet = new GiantPlanet("Jupiter", 139822, 1.898 * Math.Pow(10, 27), "Gas");
            Console.WriteLine(giantplanet.ToString());
            TerrestrialPlanet terrestrialplanet = new TerrestrialPlanet("Earth", 12742, 5.972 * Math.Pow(10,24), true);
            Console.WriteLine(terrestrialplanet.ToString());

            WaitForAnyKey();


        }

        static void WaitForAnyKey()
        {
            Console.WriteLine("\nPress any input key to continue:");
            Console.ReadKey();
        }
    }
}
