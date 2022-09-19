/* PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI 3 SKAIČIUS (A, B, C) IR IŠVEDA (A + B)*C BEI A*C + B*C */


using System;

namespace NETLesson01_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius:");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"({A} + {B})*{C} ={(A + B) * C}");
            Console.WriteLine($"{A}* {C} + {B}*{C} = {A * C + B * C}");
        
        }
    }
}
