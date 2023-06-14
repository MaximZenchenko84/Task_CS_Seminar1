// Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка)
using System;

namespace ConsoleApplication1
{
    class TaskCS3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a = ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0) { Console.WriteLine("Введенное число является четным"); }
            else { Console.WriteLine("Введенное число не является четным"); }
        }
    }
}
