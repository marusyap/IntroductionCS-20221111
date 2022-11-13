/* 14. С клавиатуры вводятся два числа a и b.
Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
*/

Console.WriteLine("Введите целое число a: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число b меньше a: ");
int b=Convert.ToInt32(Console.ReadLine());
if (a%b==0) Console.WriteLine($"Число {a} кратно числу {b}");
else Console.WriteLine($"Остаток от деления числа {a} на число {b} равен {a%b}");

