//76. Написать программу возведения числа А в целую положительную степень B


Console.WriteLine("Введите число a: ");
double a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число b: ");
int b=Convert.ToInt32(Console.ReadLine());
double Power(double a,int b)
{
    if (b>0) return Power(a,b-1)*a;
        else
            if (b<0) return Power(a,b+1)*1/a;
                else return 1;
}

System.Console.WriteLine($"{a} в степени {b} равно {Power(a,b)}");

