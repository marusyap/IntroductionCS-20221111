// Задать номер четверти, показать диапазоны для возможных координат

int a;
do
{
    Console.WriteLine("Задайте номер четверти от 1 до 4): ");
    a=Convert.ToInt32(Console.ReadLine());
}
while (a<0 || a>4);
if (a==1) Console.WriteLine($"В {a} четверти x>0; y>0");
if (a==2) Console.WriteLine($"В {a} четверти x<0; y>0");
if (a==3) Console.WriteLine($"В {a} четверти x<0; y<0");
if (a==4) Console.WriteLine($"В {a} четверти x>0; y<0");


