// 73. Найти сумму элементов от M до N, N и M заданы

int N;
Console.WriteLine("Введите целое число M: ");
int M=Convert.ToInt32(Console.ReadLine());
do
{
Console.WriteLine("Введите целое число N больше M: ");
N=Convert.ToInt32(Console.ReadLine());
}
while (M>N);

int Sum(int m,int n)
{
    if (m==n) return m;
    else
     return Sum(m+1,n)+m;
}

Console.WriteLine($"Сумма чисел от {M} до {N}: ");
System.Console.WriteLine(Sum(M,N));

