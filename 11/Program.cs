// 11. Дано число больше 9. Вывести на экран  вторую цифру числа с конца

Console.WriteLine("Введите целое число N больше 9: ");
int N=Convert.ToInt32(Console.ReadLine());
int b=N/10%10;
Console.WriteLine($"Вторая цифра с конца числа {N} равна {b}");

