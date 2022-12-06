// 74. Найти сумму цифр числа

Console.WriteLine("Введите целое число N: ");
int N=Convert.ToInt32(Console.ReadLine());

int SumDigit(int N)
{
    if (N==0) return 0;
    else return SumDigit(N/10)+N%10;    
}

Console.WriteLine($"Сумма чисел числа {N} равна {SumDigit(N)}");

