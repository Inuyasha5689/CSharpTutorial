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

            bool CanIVote = true;

            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Samllest Integer : {0}", int.MinValue);

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