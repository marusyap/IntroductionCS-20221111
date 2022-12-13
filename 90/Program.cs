﻿/* 90. Есть два массива info и data.
Массив data состоит из нулей и единиц хранящий числа в двоичном представлении.
Числа идут друг за другом без разделителей.
Массив info состоит из чисел, которые представляют количество бит чисел из массива data.
Составить массив десятичных представлений чисел массива data с учётом информации из
массива info.
Пример:
входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }

выходные данные:
1, 7, 0, 1
 
То есть, 2 бита, потом еще 3 бита, потом еще 3 бита и еще 1 бит. Переводим биты в десятичное представление.
*/

int[] data={1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 1, 0, 1};
int[] info={2, 4, 5, 2 };
int s=0;

for (int i=0;i<info.Length;i++)
    s=s+info[i];
if (s!=data.Length) Console.WriteLine("Количество бит чисел не совпадет с количеством чисел");
else
{
    int k=0;
    for (int j=0;j<info.Length;j++)
    {    
        int d=0;
        for (int i=0;i<info[j];i++)
        {
            d=d+data[i+k]*(int)Math.Pow(2,info[j]-i-1);
        }
        k=k+info[j];
        Console.Write($"{d} ");
    }
}
