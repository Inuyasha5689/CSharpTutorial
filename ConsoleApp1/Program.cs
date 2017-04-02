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
            Console.WriteLine("String Length : {0}", randString.Length);
            Console.WriteLine("String Contains is : {0}", randString.Contains("is"));
            Console.WriteLine("Index of is : {0}", randString.IndexOf("is"));
            Console.WriteLine("Remove String : {0}", randString.Remove(0, 6));
            Console.WriteLine("Insert String : {0}", randString.Insert(10, "short "));
            Console.WriteLine("Replace String : {0}", randString.Replace("string", "sentence"));
            Console.WriteLine("Compare A to B : {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));



            Console.ReadLine();

        }
    }
}