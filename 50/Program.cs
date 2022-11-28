//50. Выяснить являются ли три числа сторонами треугольника

Console.WriteLine("Введите целое число a: ");
double a=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите целое число b: ");
double b=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите целое число c: ");
double c=Convert.ToDouble(Console.ReadLine());

bool CheckTriangle(double a,double b,double c)
{
    return a+b>c && a+c>b && b+c>a;
}



if (CheckTriangle(a,b,c)) System.Console.WriteLine($"Числа {a},{b},{c} являются сторонами треугольника");
else System.Console.WriteLine($"Числа {a},{b},{c} не являются сторонами треугольника");




