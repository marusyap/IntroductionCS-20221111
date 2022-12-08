﻿/* 89-1. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в».
 Покажите все слова (слова не обязательно осмысленные), состоящие из n букв,
 которые можно построить из букв этого алфавита
 */
    
 void Words(string A, ref string w, int N)
    {
        if (N < 1)
        {
            Console.Write($"{w} ");
            return;
        }
        foreach (char c in A)        
        {
            w=w+c;
            Words(A,ref w, N-1);
            w = w.Remove(w.Length - 1);
        }
    }
    
    Console.WriteLine("Введите количество букв, из которых будет состоять слово: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string word = "";
    Words("KLMN", ref word, n);
