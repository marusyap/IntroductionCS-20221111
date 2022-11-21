// 27. Возведите число А в натуральную степень B используя цикл.

Console.WriteLine("Введите число a: ");
double a=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите натуральное число b: ");
int b=Convert.ToInt32(Console.ReadLine());

double Power(double x,int y)
{
    double p=x;
    for (int i=1;i<y;i++) p=p*x;
    return p;
}
Console.WriteLine($"Число {a} в степени {b} равно {Power(a,b)}");
