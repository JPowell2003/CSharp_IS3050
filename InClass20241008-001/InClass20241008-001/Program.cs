using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace InClass20241008_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Basic if else syntax
            //Needs a Boolean to evaluate
            Boolean Is_It_Hot_Outside;
            Is_It_Hot_Outside = false;
            if (Is_It_Hot_Outside == true)
            {
                Console.WriteLine("It's hot outside, drink water");
            }
            else
            {
                Console.WriteLine("It's not hot outside today");
            }

            //Is it possible to have user input temperature and then have it output if it's hot or not
            Console.WriteLine("What Temperature is it outside?");
            String TemperatureOutside = Console.ReadLine();
            Int32.TryParse(TemperatureOutside, out int Temperature);

            if (Temperature <= 43)
            {
                Console.WriteLine("It is cold outside today, wear a jacket");
            }
            else if (Temperature >= 110)
            {
                Console.WriteLine("It is hot outside, drink plenty of water");
            }
            else
            {
                Console.WriteLine("It's not a bad day, not too hot or cold");
            }

            //Declare a random int gamma
            //Add an if else, if gamma is between 0 and 1 million, inclusive
            //Print a message, else print another message
            Random rand = new Random();
            int gamma = rand.Next();
            if (gamma >= 0 && gamma <= 1000000)
            {
                Console.WriteLine("The number that was generated is between 0 and 1 million");
            }
            else if (gamma <= 0)
            {
                Console.WriteLine("The number generated is a negative");
            }
            else
            {
                Console.WriteLine("The number generated is above 1 million");
            }

            //For loop. runs from i = 0 until i = 4, prints only odd values of i
            for (int i = 0; i < 5; i++)
            {
                if (i%2 == 1)
                {
                    Console.WriteLine("i = " + i);
                }
            }
            //Write a for loop with no if statement 
            //print just the numbers divisible by 3 from 3 to 15
            for(int i = 3; i <= 15; i = i + 3)
            {
                Console.WriteLine("i = " + i);
            }

            //if k is 9 break out of loop
            for (int k = 3; k <= 15; k += 3)
            {
                if (k==9)
                {
                    break;
                }
            }
        }
    }
}
