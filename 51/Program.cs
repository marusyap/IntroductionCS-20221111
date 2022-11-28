/* 51. С клавиатуры вводится число N. Затем вводятся N чисел.
Определить сколько чисел больше 0 введено с клавиатуры
*/

Console.WriteLine("Введите целое число N: ");
int N=Convert.ToInt32(Console.ReadLine());
int[] t;
t=new int[N];
int s=0;
Console.WriteLine("Введите элементы массива: ");
for(int i=0;i<t.Length;i++)
    t[i]=Convert.ToInt32(Console.ReadLine());
for(int i=0;i<t.Length;i++)
{
    if (t[i]>0) s++;
}

Console.WriteLine($"Количество положительных элементов равно {s}: ");

