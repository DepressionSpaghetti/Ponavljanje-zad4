using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=0, y=0, z=0;
            Console.WriteLine("Upisite x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite z");
            z = Convert.ToInt32(Console.ReadLine());

            if (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) == z && x > 0 && y > 0 && z > 0)
            {
                Console.WriteLine("Trokut je pravokutan");
            }
            else Console.WriteLine("Trokut nje pravokutan");

            Console.ReadKey();
        }
    }
}
