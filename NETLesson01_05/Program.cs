/* PARAŠYTI PROGRAMĄ KURI IŠVEDA DVIEJŲ VARTOTOJO ĮVEDAMŲ SKAIČIŲ  SANDAUGA, DALYBĄ, SUMĄ, SKIRTUMĄ */

using System;

namespace NETLesson01_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius:");
            int number1 = Int32.Parse(Console.ReadLine());
            int number2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{number1} * {number2} = {number1*number2}");
            Console.WriteLine($"{number1} / {number2} = {number1 / number2},{number1%number2}");
            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
        }
    }
}
