// 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

Console.WriteLine("Введите целое число N больше 9: ");
int N=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Последняя цифра числа {N} это цифра {N%10}");
