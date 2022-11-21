// 18. По двум заданным числам проверять является ли одно квадратом другого.


double f(double x)
{
    double res=x*x;
    return res;
}
Console.WriteLine("Введите число a: ");
double a=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b: ");
double b=Convert.ToDouble(Console.ReadLine());
if (f(a)==b || f(b)==a) Console.WriteLine($"Одно число является квадратом другого");
else Console.WriteLine($"Одно число не является квадратом другого");
