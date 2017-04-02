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

            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.000000000000002;
            Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);

            Console.WriteLine("Biggest decimal : {0}", Double.MaxValue.ToString("#"));
           

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