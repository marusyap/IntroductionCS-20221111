// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел

Console.WriteLine("Введите число a: ");
double a=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b: ");
double b=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число c: ");
double c=Convert.ToDouble(Console.ReadLine());
double max=a;
if (b>=max) max=b;
if (c>=max) max=c;
Console.WriteLine($"Максимальное число из чисел {a} {b} {c} число {max}");