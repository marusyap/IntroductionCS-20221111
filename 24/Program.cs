// 24. Вывести на экран таблицу квадратов чисел от 1 до N

double f(double x)
{
    double res=x*x;
    return res;
}
Console.WriteLine("Введите целое число N: ");
int N=Convert.ToInt32(Console.ReadLine());
for (int i=1;i<=N;i++)
{
    Console.WriteLine($"Квадрат числа {i} равен {f(i)}");
}

