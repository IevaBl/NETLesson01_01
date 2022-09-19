/* PARAŠYTI PROGRAMĄ KURI PRAŠO VARTOTOJO ĮVESTI SIMBOLĮ IR IŠ JŲ NUPIEŠIA STAČIAKAMPĮ.
 * NAUDOTI STRINGINTERPOLATION{0} */

using System;

namespace NETLesson01_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite simboli:");
            var sign = Console.ReadLine();
            Console.WriteLine($"{sign}{sign}{sign}{sign}");
            Console.WriteLine($"{sign}  {sign}");
            Console.WriteLine($"{sign}  {sign}");
            Console.WriteLine($"{sign}  {sign}");
            Console.WriteLine($"{sign}{sign}{sign}{sign}");
        }
    }
}
