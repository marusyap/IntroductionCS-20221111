// 30. Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите целое число N: ");
int N=Convert.ToInt32(Console.ReadLine());
int Prod(int x)
{
    int p=1;
    for (int i=1;i<=x;i++) p=p*i;
    return p;
}
Console.WriteLine($"Произведение чисел от 1 до {N} (Факториал {N}) равно {Prod(N)}");