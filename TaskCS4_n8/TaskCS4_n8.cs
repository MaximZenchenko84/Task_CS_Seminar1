// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N
using System;

namespace ConsoleApplication1
{
    class TaskCS4
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N = ");
            int N = int.Parse(Console.ReadLine());
            int current_even = 2;
            if (current_even > N) { Console.Write("Нет четных чисел до числа "); Console.WriteLine(N);}
            else
            {
                Console.Write("Все четные числа до числа "); Console.Write(N); Console.WriteLine(": ");
                do
                {
                    Console.WriteLine(current_even);
                    current_even += 2;
                }
                while (current_even <= N);
            }
        }
    }
}
