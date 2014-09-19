using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            int a = Convert.ToInt32(Console.ReadLine());

            while (i <=10)
            {
                int product = i * a;
                Console.WriteLine("\n" + product + "\n");
                break;
            }
            while (a <= 10)
            {
                break;
            }
        }
    }
}
