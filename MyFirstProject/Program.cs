using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            long bignumber = 900000000L;
            double negpi = -3.14159265359D;
            float pi = 3.14159265359F;
            decimal money = 10.99M;
            Console.WriteLine(age);
            Console.WriteLine(bignumber);
            Console.WriteLine(pi);
            Console.WriteLine(negpi);
            Console.WriteLine(money);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);


            string name = "Kevin";
            char letter = 'K';
            Console.WriteLine(name);
            Console.WriteLine(letter);
            Console.WriteLine("Your name is: " + name);


        }
    }
}
