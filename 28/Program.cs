// 28. Определить количество цифр в числе. Сделать подпрограмму.

int CountDigits(int number)
{
    number=Math.Abs(number);
    int count=0;
    if (number==0) count=1;
    while (number>0)
    {
        number=number/10;
        count++;
    }
    return count;
}
Console.WriteLine("Введите целое число N: ");
int N=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе {N} {CountDigits(N)}: ");
