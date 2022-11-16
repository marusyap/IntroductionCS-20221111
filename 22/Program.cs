// Программа проверяет число на палиндромом.

Console.WriteLine("Введите целое число: ");
int N=Convert.ToInt32(Console.ReadLine());
int res=0;
int i;
int k=N;
while (k>0)
{
    i=k%10;
    res=res*10+i;
    k=k/10;
}
Console.WriteLine($"число: {res}");
if (res==N) Console.WriteLine($"Число {N} является палиндромом");
else Console.WriteLine($"Число {N} не является палиндромом");