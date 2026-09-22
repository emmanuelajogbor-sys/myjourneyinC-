using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arthimetic_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Arthimetic Calculator");
            Console.WriteLine();
            Console.WriteLine();
           /*nt Add = 1;
            int Sub = 2;
            int Multi = 3;
            int divide = 4;*/
            
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Mulitiplication");
            Console.WriteLine("4. Division");

            Console.WriteLine();

            Console.WriteLine("MAKE A SELECTION!");
            int choice = Convert.ToInt32(Console.ReadLine());
            

            Console.Write("Enter First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            /*f (userinput == 1)
             {
                 Console.WriteLine("addition");
                 int A = Convert.ToInt32(Console.ReadLine());
                 int B = Convert.ToInt32(Console.ReadLine());


                 int add = A + B;
                 Console.WriteLine(
             }*/

            Console.Write("Enter your Second Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (choice == 1)
            {
                double add = num1 + num2;
                Console.WriteLine();
                Console.Write("Ans: " + num1 + "+" + num2 + " = " + add);
            }
            else if (choice == 2)
            {
                double sub = num1 - num2;
                Console.WriteLine();
                Console.Write("Ans: " + num1 + "-" + num2 + " = " + sub);
            }
            else if (choice == 3)
            {
                double multi = num1 * num2;
                Console.WriteLine();
                Console.WriteLine("Ans: " + num1 + "*" + num2 + "= " + multi);
            }
            else if (choice == 4)
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error, can't be divided by 0");
                }
                else
                {

                double divide = num1 / num2;
                Console.WriteLine();
                Console.WriteLine("Ans: " + num1 + "/" + num2 + "= " + divide);

                }
            }
            else
            {
                Console.WriteLine("try again, Selectfrom 1-4 this time");
            }

            Console.WriteLine("THANK YOU  FOR USING MY CALCULATOR!!! KILOMENE!!!");
         
        }
    }
}
