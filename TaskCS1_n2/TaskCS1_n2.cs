// Напишите программу, которая на вход принимает два числа и выдает,
// какое число большее, а какое меньшее

using System;

namespace Task1
{
    class TaskCS1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("max = ");
            if (a > b)
            {
                
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}


