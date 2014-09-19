using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableOfSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            int a = Convert.ToInt32(Console.ReadLine());

            while (i <= 50)
            {
                int sum = i + a;
                Console.WriteLine("\n" + sum + "\n");
                break;
            }
            while (a <= 50)
            {
                break;
            }
        }
    }
}
