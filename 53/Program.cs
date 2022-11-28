/* 53. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1,
y = k2 * x + b2, b1 k1 и b2 и k2 заданы
*/

Console.WriteLine("Введите угловой коэффициент первой прямой k1: ");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите свободный член первой прямой b1: ");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите угловой коэффициент первой прямой k2: ");
double k2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите свободный член первой прямой b2: ");
double b2=Convert.ToDouble(Console.ReadLine());

if (k1==k2) Console.WriteLine($"Заданные прямые не пересекаются (параллельны)");
else
{
    double x=(b2-b1)/(k1-k2);
    double y=k1*((b2-b1)/(k1-k2))+b1;
    Console.WriteLine($"Точка пересечения заданных прямых ({x},{y}) ");
}