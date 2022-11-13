// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них.

Console.WriteLine("Введите число a: ");
double a=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b: ");
double b=Convert.ToDouble(Console.ReadLine());
if (a<=b)
{
    Console.WriteLine($"Максимальное число из чисел {a} и {b} число {b}");
}
else Console.WriteLine($"Максимальное число из чисел {a} и {b} число {a}");
