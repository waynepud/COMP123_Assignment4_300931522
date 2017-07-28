using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Wayne Pud
 * Date: July 28, 2017
 * Description: This is the TerrestrialPlanet subclass
 * Version: 0.2 - Added ToString method specific to TerrestrialPlanet class to show oxygen
 */

namespace COMP123_Assignment4_300931522
{
    /// <summary>
    /// This is the TerrestrialPlanet class
    /// </summary>
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // private instance variables (fields)
        private bool _oxygen;

        // public properties

        /// <summary>
        /// This is the constructor which takes the parameters of the planet base class and adds an oxygen bool variable
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        // constructors -----------------------------------------------------------
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        // private methods


        // public methods
        /// <summary>
        /// These public methods will return if satisfied
        /// </summary>
        public bool HasMoons()
        {
            return MoonCount > 0;
        }

        public bool Habitable()
        {
            return _oxygen = true;
        }

        /// <summary>
        /// Extra: This is the ToString method specific for TerrestrialPlanet Class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = this.Name + " | " + " Diameter = " + this.Diameter + " km | Mass = " + this.Mass + " kg | Oxygen? = " + this._oxygen;
            return output;
        }

    }
}