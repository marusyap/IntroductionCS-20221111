// 29. Подсчитать сумму цифр в числе. Сделать подпрограмму.

Console.WriteLine("Введите целое число N: ");
int N=Convert.ToInt32(Console.ReadLine());

int Sum(int x)
{
    int sum=0;
    int k=N;
    while (k>0)
    {
        int s=k%10;
        sum=sum+s;
        k=k/10;
    }
    return sum;
}
Console.WriteLine($"Сумма цифр числа {N} равен {Sum(N)}");