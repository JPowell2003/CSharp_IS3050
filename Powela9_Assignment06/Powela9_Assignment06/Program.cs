/*
 Name: Jay Powell
 Email: powela9@mail.uc.edu
 Assignment Title: Assignment 06
 Due Date: 10/10/2024
 Course: IS 3050
 Semester/Year: Fall 2024
 Brief Description: This assignment covers basic C# tasks like declaring variables, assigning values, and printing results to the console
 Citations:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powela9_Assignment06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question a:
            Console.WriteLine("Hi, my name is Jay. I would rather be reading then coding right now");
            
            //Question b through d:
            int epsilon;
            epsilon = 100;
            Console.WriteLine("The value of epsilon is: " + epsilon);

            //Question e through g:
            string MNumber;
            MNumber = "M14507101";
            Console.WriteLine("My MNumber is " + MNumber);

            //Question h through i:
            double producePriceAtLocalStore;
            producePriceAtLocalStore = 1.54;
            //https://www.kroger.com/p/fresh-california-yellow-peach-each/0000000004038

            //Question j:
            Console.WriteLine("The total price for purchasing 100 peaches at $1.54 each, including 7.05% sales tax is " + (producePriceAtLocalStore * 100 * (1 + 0.0705)));

        }
    }
}
