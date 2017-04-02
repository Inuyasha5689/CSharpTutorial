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

            decimal decPiVal = 3.141592653589793238462643382M;
            decimal decBigNum = 3.0000000000000000000000000000011M;

            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Samllest long : {0}", long.MinValue);

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