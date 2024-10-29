using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass20241029_001
{
    /// <summary>
    /// This class models a cooler that we found in out classroom.
    /// </summary>
    internal class Cooler 
    {
        //Properties of a cooler
        private string _color; //prefix private properties with underscore
        //Add property called cost
        private double _cost;

        //Declare and instantiate in program.cs

        //Everytime you create a private property add a getter and a setter
        public string color
        {
            get { return _color; }
            set
            {
                if (value.Length > 0)
                { _color = value; }
            } //prevents null variables
        }

        public double cost
        {
            get { return _cost; }
            set
            {
                if (value >= 0) //reject negative numbers
                { _cost = value; }
            }
        }
    }
}
