//Navid-Derakhshandeh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{

    class Rectangle
    {
        private double n;

        public Rectangle(double x)
        {
            this.n = x;

        }
        public static double operator *(Rectangle s1, Rectangle s2)
        {
            return s1.n * s2.n;
        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo conkey;
            double x;
            double xn;
            do
            {
                Console.WriteLine("Enter the number of length");
                x = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of width ");
                xn = Double.Parse(Console.ReadLine());

                Rectangle newrect1 = new Rectangle(x);

                Console.WriteLine("Space equal by {0}.", x * xn);

                conkey = Console.ReadKey();
            } while (conkey.Key != ConsoleKey.Escape);
        }
    }
}