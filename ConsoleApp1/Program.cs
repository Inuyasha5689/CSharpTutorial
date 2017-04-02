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

            float fltPiVal = 3.141592F;
            float fltBigNum = 3.000002F;
            Console.WriteLine("DBL : PI + bigNum = {0}", fltPiVal + fltBigNum);

            Console.WriteLine("Biggest Float : {0}", float.MaxValue.ToString("#"));
           

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