using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleinput_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello my name is Ose");

            Console.Write("Enter you first and last name: ");
            string name = Console.ReadLine();

            //Console.WriteLine(name + ", thank you for trusting me with your name");

            Console.Write("Enter your Age: ");
            string ageinput = Console.ReadLine();
            int age = Convert.ToInt32(ageinput);

            //Console.WriteLine("damnnnnnnn!!!!, you are " + age + " year old");

            Console.Write("Your name is " + name + " and you are " + age + " years old");
            


            Console.ReadLine();
        }
    }
}
