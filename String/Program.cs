using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            str += " world";
            Console.WriteLine(str);
            Console.WriteLine($"это строка {str} "); 
            Console.WriteLine($"это первый символ {str[0]} ");
            Console.WriteLine($"это первый символ {str[4]} ");
            Console.WriteLine($"Длина строки {str.Length} ");
            int lenght = str.Length;
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine($"{i} -> {str[i]}");
            }
            Console.ReadLine();
        }
    }
}
