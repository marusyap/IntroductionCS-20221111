// 72. Показать натуральные числа от M до N, N и M заданы


int N;
Console.WriteLine("Введите целое число M: ");
int M=Convert.ToInt32(Console.ReadLine());
do
{
Console.WriteLine("Введите целое число N больше M: ");
N=Convert.ToInt32(Console.ReadLine());
}
while (M>N);


void Numbers(int M,int N)
{
    if (M<=N)
    {
        System.Console.WriteLine(M);
        Numbers(M+1,N);
    }
}

Console.WriteLine($"Числа от {M} до {N}: ");
Numbers(M,N);
