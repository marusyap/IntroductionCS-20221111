// Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Введите число a: ");
int a=Convert.ToInt32(Console.ReadLine());
if (a%7==0 && a%23==0) Console.WriteLine($"Число {a} кратно 7 и 23");
else Console.WriteLine($"Число {a} не кратно 7 и 23");

