using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace switchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter a day of the week");
            string noofday = Console.ReadLine();
            int day = Convert.ToInt32(noofday);

            if (day == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (day == 2)
            {
                Console.WriteLine("Tuesday");
            
            }
            else if (day == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (day == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (day == 5)
            {
                Console.WriteLine("Friday"); 
            }
            else
            {
                Console.WriteLine("input the day");
                string weekenday = Console.ReadLine();
                
                Console.WriteLine();

                Console.WriteLine(weekenday + " weekend"); */



                // or

              Console.WriteLine("Enter day of the week");
              string no_day = Console.ReadLine();
              int day = Convert.ToInt32(no_day);

            switch (day)
            {
                case 1: Console.WriteLine("Monday");
                    break;

                case 2: Console.WriteLine("Tuesday");
                    break;
                case 3: Console.WriteLine("Wednesday");
                    break;
                case 4: Console.WriteLine("Thursday");
                    break;
                case 5: Console.WriteLine("Friday");
                    break;
                case 6: Console.WriteLine("Saturday");
                    break;
                case 7: Console.WriteLine("Sunday");
                    break;
                default: Console.WriteLine("Invalid, enter a value between 1 and 7");
                    break;
            }

            Console.ReadLine();

            }
            
        }
    }

