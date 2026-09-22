using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoop
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("hi");
            Console.WriteLine("hi");
            Console.WriteLine("hi");
            Console.WriteLine("hi");*/

            Console.Write("what do you want to repeat?: ");
            string message = Console.ReadLine();

            Console.Write("How many times do you want to repeat it?: ");
            string counter = Console.ReadLine();
            int loopcounter = Convert.ToInt32(counter);
            /* or
            int loopcounter = Convert.ToInt32(Console.ReadLine());*/

            if (loopcounter <= 0)
            {
                Console.WriteLine("Sorry, Please enter value above 0");
            }

            else
            {
                for (int i = 0; i < loopcounter; i++ /* i = i + 1 or i += 1*/ )
                {
                    Console.WriteLine(message);
                }
            }

            
            

            /*for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }*/
            
        } 
    }
}
