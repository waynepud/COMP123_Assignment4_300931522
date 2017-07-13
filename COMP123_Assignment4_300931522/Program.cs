using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Wayne Pud
 * Date: July 13, 2017
 * Description: Assignment 4 - Abstract planets
 * Version: 0.2 - Added the object creators
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
            Console.WriteLine(giantplanet);
            TerrestrialPlanet terrestrialplanet = new TerrestrialPlanet("Earth", 12742, 5.972 * Math.Pow(10,24), true);
            Console.WriteLine(terrestrialplanet);



            // Wait for another key method?
        }
    }
}
