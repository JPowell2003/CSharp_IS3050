using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass20241029_001
{
    internal class Program 
    {
        static void Main(string[] args) //Entry Point
        {
            //declare an object of type cooler
            Cooler myCooler;
            myCooler = new Cooler(); //Instantiate that object

            //Need to have a getter and a setter in order to declare properties
            myCooler.color = "Dirty Gray"; //Invokes the setter
            Console.WriteLine(myCooler.color); //Invokes the getter

            //Try to put a null value
            //Has a break point in Cooler at the setter
            myCooler.color = "";
            Console.WriteLine("New color of our cooler: " + myCooler.color);

            //Involing the setter and the getter for the cost of cooler
            myCooler.cost = 15.50;
            Console.WriteLine("The Price of the Cooler is $" + myCooler.cost);
            Console.WriteLine("The Price of 20 Coolers is $" + myCooler.cost * 20);
        }
    }
}
