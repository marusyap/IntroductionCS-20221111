﻿// 97. Сформировать трехмерный массив неповторяющимися двузначными
//числами показать его построчно на экран выводя индексы
//соответствующего элемента


using System;

class Spiral
{
    static void DisplayArray(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++) Console.Write("{0,3} ", a[i, j]);
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter a non-negative number (0 - exit): ");

            int n;
            if (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0) break;

            Console.WriteLine();

            int[,] a = new int[n, n];

            int i = 0, j = 0;

            int value = 1;

            while (n != 0)
            {
                int k = 0;
                do { a[i, j++] = value++; } while (++k < n - 1);
                for (k = 0; k < n - 1; k++) a[i++, j] = value++;
                for (k = 0; k < n - 1; k++) a[i, j--] = value++;
                for (k = 0; k < n - 1; k++) a[i--, j] = value++;

                ++i; ++j; n = n < 2 ? 0 : n - 2;
            }

            DisplayArray(a);
            Console.WriteLine();
        }
    }
}