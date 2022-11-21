// 17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int N;
do
{
    Console.WriteLine("Введите целое число N от 1 до 7: ");
    N=Convert.ToInt32(Console.ReadLine());
}
while (N<1 || N>7);
if (N>5) Console.WriteLine($"День недели под номером {N} выходной");
else Console.WriteLine($"День недели под номером {N} не выходной");
