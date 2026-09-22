using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            /* or Console>Write("Enter your age");
             * string age = Console.ReadLine();
             * int actualAge = Convert.ToInt32(age);
             */



            /* if (age >= 0)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }*/

            // Condition ? true : false

            string result = age >= 0 ? "Valid" : "Invalid";
            Console.WriteLine(result);

            //or

            // Console.WriteLine(age >= 0 ? "Valid" : "Invalid");
        }
    }
}
