using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTut.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            //Other Data Types
            //byte : 8-bit unsigned int 0 to 255
            //char : 16-bit unicode character
            //sbyte : 8-bit signed int 128 to 127
            //short : 16-bit signed int -32, 768 to 32, 767
            //uint : 32-bit unsigned int - to 4,294,967,295
            //ulong : 64-big unsigned int - to 18,446,744,073,709,551,615
            //ushort : 16-big unsigned int - to 65,535

            DateTime awesomeDate = new DateTime(1974, 12, 21);
            Console.WriteLine("Day of Week : {0}", awesomeDate.DayOfWeek);

            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);

            Console.WriteLine("New Date : {0}", awesomeDate.Date);

            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            lunchTime = lunchTime.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("New Time : {0}", lunchTime.ToString());


            Console.ReadLine();

        }

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0} : ", name);
        }
    }
}