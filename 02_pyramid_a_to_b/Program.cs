/*
2. Вводяться цілі додатні  числа A і B (A <B). Вивести всі цілі числа  від  A до B  включно. Кожне
число повинно виводитися з нового рядка; при цьому каждое число повинно  виводитися число разів рівне  його значенню
Наприклад: якщо А = 3, а В = 7, то програма повинна  сформувати у  консолі наступний вивід:
3 3 3
4 4 4 4
5 5 5 5 5
6 6 6 6 6 6
7 7 7 7 7 7 7
 */

using System;


namespace _02_pyramid_a_to_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A (example 3):\t");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter B (more than {a}):\t");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                // Этот цикл проходит по столбцам
                for (int j = 1; j <= i; j++)
                    Console.Write($"{i} ");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
