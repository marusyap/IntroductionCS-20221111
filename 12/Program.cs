/* 12. С клавиатуры вводится целое число из диапазона  [10, 99].
 Показать наибольшую цифру числа
*/

int N;
do
{
    Console.WriteLine("Введите целое число N больше 9 и меньше 99: ");
    N=Convert.ToInt32(Console.ReadLine());
}
while (N<10 || N>99);
if ((N/10-N%10)>=0) Console.WriteLine($"Наибольшая цифра числа {N} равна {N/10}");
else Console.WriteLine($"Наибольшая цифра числа {N} равна {N%10}");


