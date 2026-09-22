using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int i = 0;

            while (i < 10)
            {

                Console.WriteLine(i);
                i++;
            }*/


            Console.Write("Enter the first number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the Second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int answer = numberA * numberB;

            Console.WriteLine("what is the Value of " + numberA + "x" + numberB + "?");
            int input = default;
            Console.WriteLine();

           /* while (answer != input)
            {
                Console.WriteLine("Enter your answer");
                input = Convert.ToInt32(Console.ReadLine());


                if (answer == input)
                {
                    Console.WriteLine("Correct, well done!!!!");
                }

                else
                {
                    Console.WriteLine("try again jor, you no be mumu");
                }
            }*/

            // example of do-while loop

            do
            {
                Console.Write("Enter your answer: ");
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();


                if (answer == input)
                {
                    Console.WriteLine("Correct, well done!!!!");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("try again jor, you no be mumu");
                    Console.WriteLine();
                }
            } while (answer != input);

            Console.ReadLine();
        }
    }
}
