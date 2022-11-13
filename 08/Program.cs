// 8. Вывести на экран числа от -N до N

Console.WriteLine("Введите целое число N: ");
int N=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Числа от -{N} до {N}");
for (int j=-N;j<=N;j++)
{
    Console.Write($"{j} ");
}