using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Wayne Pud
 * Date: July 13, 2017
 * Description: This is the GiantPlanet subclass
 * Version: 0.1 - Created GiantPlanet Class and added variables and methods
 */

namespace COMP123_Assignment4_300931522
{
    /// <summary>
    /// This is the GiantPlanet subclass
    /// </summary>
    public class GiantPlanet : Planet
    {
        // private instance variables (fields)
        private string _type;

        // public properties

        /// <summary>
        /// This is the constructor for GiantPlanet subclass which will take 3 parameters inherited from the planet class with the addition of a type variable
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        // constructors -----------------------------------------------------------
        public GiantPlanet(string name, double diameter, double mass, string type) : base (name, diameter, mass)
        {
            this._type = type; //either gas or ice?
        }


        // private methods
        
        /// <summary>
        /// These public bool methods will return true if the condition is satisfied
        /// </summary>
        /// <returns></returns>
        // public methods
        public bool HasMoons()
        {
            return MoonCount > 0;
        }

        public bool HasRings()
        {
            return RingCount > 0;
        }
    }
}
