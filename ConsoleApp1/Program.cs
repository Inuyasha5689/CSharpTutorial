using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Numerics;

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

            Console.WriteLine("Currency : {0:c}", 23.455);
            Console.WriteLine("Pad with 0s : {0:d4}", 23);
            Console.WriteLine("3 Decimals : {0:f3}", 23.455);
            Console.WriteLine("Commas : {0:n4}", 2300);


            Console.ReadLine();

        }
    }
}