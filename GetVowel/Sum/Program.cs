using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A Number: ");
            bool Valid = true;
            while (Valid == true)
            {
                double num = Convert.ToDouble(Console.ReadLine());
                double sum = num += num;
                Console.WriteLine(sum);
                if (num >= 999)
                {
                    Valid = false;
                    break;
                }
            }

        }
    }
}
