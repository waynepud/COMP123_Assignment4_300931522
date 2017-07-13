using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Wayne Pud
 * Date: July 13, 2017
 * Description: This is the planet abstract class
 * Version: 0.3 - Added main constructor and override method
 */

namespace COMP123_Assignment4_300931522
{
    /// <summary>
    /// This is the planet abstract class
    /// </summary>
    public abstract class Planet
    {
        // private instance variables (fields)
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;


        // public properties
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }

        public double Mass
        {
            get
            {
                return this._mass;
            }
        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }   

        
        /// <summary>
        /// This is the main constructor of the planet abstract class that takes 3 parameters: name, diameter and mass and sets the values
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        // constructors -----------------------------------------------------------
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        // private methods

        // public methods
        /// <summary>
        /// This public string override method will return Name, Diameter and Mass to console
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Name, Diameter, Mass);
        }
    }
}
