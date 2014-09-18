using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A Vowel: ");
            string Vowel = Console.ReadLine();
            switch (Vowel)
            {
                case "a":
                    Console.WriteLine("OK");
                    break;
                case "A":
                    Console.WriteLine("OK");
                    break;
                case "e":
                    Console.WriteLine("OK");
                    break;
                case "E":
                    Console.WriteLine("OK");
                    break;
                case "i":
                    Console.WriteLine("OK");
                    break;
                case "I":
                    Console.WriteLine("OK");
                    break;
                case "o":
                    Console.WriteLine("OK");
                    break;
                case "O":
                    Console.WriteLine("OK");
                    break;
                case "u":
                    Console.WriteLine("OK");
                    break;
                case "U":
                    Console.WriteLine("OK");
                    break;
                default:
                    Console.WriteLine("ERROR!");
                    break;
            }
        }
    }
}
