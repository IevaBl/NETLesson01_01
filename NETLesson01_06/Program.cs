/* PARAŠYTI PROGRAMĄ KURI PRAŠO VARTOTOJO ĮVESTI SKAIČIŲ IR IŠVEDA JO DAUGYBOS LENTELĘ */

using System;

namespace NETLesson01_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("parasykite skaiciu:");
            int number = Int32.Parse(Console.ReadLine());
            //Console.WriteLine($"{number}* 1 = {number * 1}");
            //Console.WriteLine($"{number}* 2 = {number * 2}");
            //Console.WriteLine($"{number}* 3 = {number * 3}");
            //Console.WriteLine($"{number}* 4 = {number * 4}");
            //Console.WriteLine($"{number}* 5 = {number * 5}");
            //Console.WriteLine($"{number}* 6 = {number * 6}");
            //Console.WriteLine($"{number}* 7 = {number * 7}");
            //Console.WriteLine($"{number}* 8 = {number * 8}");
            //Console.WriteLine($"{number}* 9 = {number * 9}");
            //Console.WriteLine($"{number}* 10 = {number * 10}");

            for (int i = 1; i <=10 ; i++)
            {
                Console.WriteLine($"{number} * {i} = {number*i}");
            }
            
        }
    }
}
