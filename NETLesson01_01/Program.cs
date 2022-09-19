/*PARAŠYTI PROGRAMĄ KURI KLAUSIĄ VARTOTOJO JO MĖGSTAMOS SPALVOS.
 * PROGRAMA TURI VISADA ATSAKYTI: MANO IRGI!*/


using System;

namespace NETLesson01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kokia tavo megstamiausia spalva?");
            var ansver = Console.ReadLine();
            Console.WriteLine($"Mano irgi megstamiausia spalva {ansver}!");
        }
    }
}
