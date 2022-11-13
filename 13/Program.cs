// 13. Удалить вторую цифру с конца целого числа введенного с клавиатуры.

Console.WriteLine("Введите целое число a больше 9: ");
int a=Convert.ToInt32(Console.ReadLine());
int b=a/100*10+a%10;
Console.WriteLine($"Число без второй цифры с конца числа {a} равна {b}");
