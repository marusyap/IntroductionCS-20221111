/* С клавиатуры вводится целое число. Вывести третью цифру числа
или сообщить, что её нет (Вывести: NO).
*/

Console.WriteLine("Введите целое число a: ");
int a=Convert.ToInt32(Console.ReadLine());
if (a<100) Console.WriteLine($"У числа {a} нет третьей цифры с конца");
else
{
    int k=a;
    while (k>999)
    {
        k=k/10;
    }
    Console.WriteLine($"Третья цифра числа {a} равна {k%10}");
}


