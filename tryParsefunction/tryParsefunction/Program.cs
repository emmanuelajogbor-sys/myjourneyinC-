using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryParsefunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string numInput = Console.ReadLine();
            int num = 0;


           bool success = int.TryParse(numInput, out num);

            if (success)
            {
                Console.WriteLine("successful: " + num);
            }

            else
            {
                Console.WriteLine("failed to convert");
            }


            Console.ReadLine();
        }
    }
}
