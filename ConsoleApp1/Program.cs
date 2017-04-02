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

            string randString = "This is a string";

            Console.WriteLine("A = a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Pad Left : {0}", randString.PadLeft(20, '.'));
            Console.WriteLine("Pad right : {0}", randString.PadRight(20, '.'));
            Console.WriteLine("Trim : {0}", randString.Trim());
            Console.WriteLine("Uppercase : {0}", randString.ToUpper());
            Console.WriteLine("Lowercase : {0}", randString.ToLower());

            string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");

            Console.Write(@"Exactly What I Typed ' \");


            Console.ReadLine();

        }
    }
}