/* PARAŠYTI PROGRAMĄ KURI PRAŠO VARTOTOJO ĮVESTI 4 SKAIČIUS IR IŠVEDA JŲ VIDURKĮ*/

using System;

namespace NETLesson01_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite keturis skaicius:");
            double numb1 = Convert.ToDouble(Console.ReadLine());
            double numb2 = Convert.ToDouble(Console.ReadLine());
            double numb3 = Convert.ToDouble(Console.ReadLine());
            double numb4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Siu skaiciu vidurkis yra: {(numb1 + numb2 + numb3 + numb4) / 4}");
        }
    }
}
