// 6. Написать программу вычисления значения функции y = sin(a). (Класс Math). 

Console.WriteLine("Введите число a: ");
double a=Convert.ToDouble(Console.ReadLine());
double y=Math.Sin(a);
Console.WriteLine($"Синус {a} равен {y}");

