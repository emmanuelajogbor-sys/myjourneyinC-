using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forlooptesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("hi");
            Console.WriteLine("hi");
            Console.WriteLine("hi");
            Console.WriteLine("hi");
            Console.WriteLine("hi");*/

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("hi");
            }

            

            for (int x = 0; x <= 10; x += 2)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("what do you want to repeat?");
            string message = Console.ReadLine();
            Console.Write("How many time do you want to repeat it? ");
            int loopcounter = Convert.ToInt32(Console.ReadLine());

            if (loopcounter <= 0)
            {
                Console.WriteLine("Please input a number greater than 0 !!!");
            }
            else
            {
                for (int y = 0; y < loopcounter; y++)
                {
                    Console.WriteLine(message);
                }
            }
            



            Console.ReadLine();
        }
    }
}
