/* PARAŠYTI PROGRAMĄ VERČIA CELSIJAUS LAIPSNIUS Į KELVINO IR FARENHEJTO
 * KELVIS= CELSIUS+ 273
 * FARENHEIT= CELSIUS* 18 /10 + 32 */

using System;

namespace NETLesson01_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cels = 15;
            int kelv = cels + 273;
            int frh = cels * 18 / 10 + 32;
            Console.WriteLine($"Laipsniai Celsijais => {cels}");
            Console.WriteLine($"Laipsniai Kelvinais => {kelv}");
            Console.WriteLine($"Laipsniai Farenheitais => {frh}");
        }
    }
}
