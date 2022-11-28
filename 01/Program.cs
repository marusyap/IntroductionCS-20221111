// 1. С клавиатуры вводится целое число. Вывести квадрат числа.

int a;
Console.Write("Введите целое число: ");
string s=Console.ReadLine();
a=Convert.ToInt32(s);
int b = a*a;
Console.WriteLine($"Квадрат числа {a} равен {b}");
