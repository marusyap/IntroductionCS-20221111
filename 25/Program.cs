// 25. Вывести на экран кубы чисел от 1 до N


double f(double x)
{
    double res=Math.Pow(x,3);
    return res;
}
Console.WriteLine("Введите целое число N: ");
int N=Convert.ToInt32(Console.ReadLine());
for (int i=1;i<=N;i++)
{
    Console.WriteLine($"Куб числа {i} равен {f(i)}");
}


