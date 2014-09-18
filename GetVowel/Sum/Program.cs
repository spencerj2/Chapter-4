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
                float num = Convert.ToInt32(Console.ReadLine());
                float sum = num += num;
                Console.WriteLine(sum);
                if (num == 999)
                {
                    Valid = false;
                }
            }

        }
    }
}
