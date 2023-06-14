
// Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел

using System;

namespace Task2
{
    class TaskCS2
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите число c = ");
            int c = int.Parse(Console.ReadLine());
            int max = a;
            if (b > max) { max = b; }
            if (c > max) { max = c; }
            Console.Write("max = ");
            Console.WriteLine(max);
        }
    }
}
