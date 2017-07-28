using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Wayne Pud
 * Date: July 28, 2017
 * Description: This is the GiantPlanet subclass
 * Version: 0.3 - Added ToString method for GiantPlanet class
 */

namespace COMP123_Assignment4_300931522
{
    /// <summary>
    /// This is the GiantPlanet subclass
    /// </summary>
    public class GiantPlanet : Planet, IHasMoons, IHasRings
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
            if (type == "Gas")
            {
                this._type = type;
            }
            else if (type == "Ice")
            {
                this._type = type;
            }
            else
            {
                type = "Not a valid type, must be either Gas or Ice";
                this._type = type;
            }
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

        /// <summary>
        /// This ToString overrides the Planet ToString method for more specifics which include planet type for GiantPlanet class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = this.Name + " | " + " Diameter = " + this.Diameter + " km | Mass = " + this.Mass + " kg | Type = " + this._type;
            return output;
        
        }
    }
}
