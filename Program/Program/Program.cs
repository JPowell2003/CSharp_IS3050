/* Documentation */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args) //Entry Point
        {
            HelloWorld(); //Call or Evoke the method

            //Invoke the cube method
            Cube(39); //This invokes the method but disgards what is returned
            int answer;
            answer = Cube(39); //Invoke and store the return value in answer
            Console.WriteLine(answer);

            int FactorialAnswer;
            FactorialAnswer = Factorial(-5);
            Console.WriteLine(FactorialAnswer);

            int FactorialWhileAnswer;
            FactorialWhileAnswer = FactorialWhile(-5);
            Console.WriteLine(FactorialWhileAnswer);

            Boolean EvenAnswer;
            EvenAnswer = checkEven(0);
            Console.WriteLine(EvenAnswer);

        }

        /// <summary>
        /// A new method to print Hello World to Console
        /// </summary>
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        /// <summary>
        /// Compute the cube of an integer
        /// </summary>
        /// <param name="num">The number to be cubed</param>
        /// <returns>The cube of num</returns>
        static int Cube(int num)
        {
            return num * num * num;
        }

        /// <summary>
        /// Compute the factorial of an integer using a while loop
        /// </summary>
        /// <param name="factorialIntFor"> Used to calculate n! </param>"
        /// <returns> The factorial of factorialInt</returns>
        static int Factorial(int FactorialIntFor)
        {
            int result = 1;
            if (FactorialIntFor < 0)
            {
                Console.WriteLine("You can't factorial a negative number");
            }
            else
            {
                for (int i = 2; i <= FactorialIntFor; i++)
                {
                    result *= i;
                }
                return result;
            }
        }

        /// <summary>
        /// Compute the factorial of an integer using a while loop
        /// </summary>
        /// <param name="factorialIntWhile"> Used to calculate n! </param>"
        /// <returns> The factorial of factorialIntWhile</returns>
        static int FactorialWhile(int FactorialIntWhile)
        {
            int resultWhile = 1;
            int counter = 1;
            if (FactorialIntWhile < 0)
            {
                Console.WriteLine("You can't factorial a negative number");
            }
            else
            {
                while (counter <= FactorialIntWhile)
                {
                    resultWhile *= counter;
                    counter++;
                }
                return resultWhile;
            }
        }

        ///<summary>
        ///Checking if a number is even, odd, or negative
        ///</summary>
        ///<param name="int alpha"> The number we're checking </param>
        ///<returns> True if value is even, false if not, always false if negative </returns>
        static Boolean checkEven(int number, string message = "")
        {
            Console.WriteLine(message);
            if (number % 2 == 0)
            {
                return true;
            }
            if (number < 0) //Change order
            {
                return false;
            }
            return false;
        }
    }
}
