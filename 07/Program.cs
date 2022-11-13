// 7. Выяснить является ли число чётным.

Console.WriteLine("Введите целое число N");
int N=Convert.ToInt32(Console.ReadLine());
if (N%2==0) Console.WriteLine($"Число {N} четное");
else Console.WriteLine($"Число {N} нечетное");