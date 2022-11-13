// 9. Вывести на экран четные числа от 1 до N

Console.WriteLine("Введите целое число N: ");
int N=Convert.ToInt32(Console.ReadLine());
int i=2;
Console.WriteLine($"Четные числа от 1 до {N}");
while (i<=N)
{
     Console.Write($"{i} ");
     i=i+2;
}
