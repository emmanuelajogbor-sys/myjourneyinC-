using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ifstatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello my name is Ose");

            //Console.Write("Enter you first and last name: ");
            //string name = Console.ReadLine();

            ////Console.WriteLine(name + ", thank you for trusting me with your name");

            //Console.Write("Enter your Age: ");
            //string ageinput = Console.ReadLine();
            //int age = Convert.ToInt32(ageinput);

            ////Console.WriteLine("damnnnnnnn!!!!, you are " + age + " year old");
            //Console.WriteLine();

            //Console.WriteLine("Your name is " + name + " and you are " + age + " years old");

            //Console.WriteLine();
            /* if (age >= 18 && age <= 35)
             {
                 Console.WriteLine("You are legally an Adult but an oldie yet");
             }

             else if (age >= 36)
             {
                 Console.WriteLine("Omo you don old o!!!");
             }*/

            /*if (age < 0 || age > 150)
            {
                Console.WriteLine("ivalid age!!");
            }
            else
            {
                if (age >= 18 && age <= 35)
                {
                    Console.WriteLine("You are legally an Adult but not an oldie yet");
                }

                else if (age >= 36)
                {
                    Console.WriteLine("Omo you don old o!!!");
                }*/

            Console.WriteLine("Enter the first number");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.WriteLine("Enter the second number");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);
            

            int answer = numberA * numberB;

            Console.WriteLine("value of " + numberA + " x " + numberB + ": ");
            string answerinput = Console.ReadLine();
            int actualanswer = Convert.ToInt32(answerinput);
            Console.WriteLine();

            if (answer == actualanswer)
            {
                Console.WriteLine("CORRECT");
            }

            else
            {
                Console.WriteLine("try again");
                Console.WriteLine("hint: remember to multiple");
            }
            Console.WriteLine();
            


                Console.ReadLine();
            }
        }
    }

