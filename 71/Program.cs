// 71. Показать натуральные числа от N до 1, N задано

Console.WriteLine("Введите целое число N: ");
int N=Convert.ToInt32(Console.ReadLine());

void Numbers(int N,int i)
{
    if (i<=N)
    {
        System.Console.WriteLine(N-i+1);
        Numbers(N,i+1);
    }
}

Console.WriteLine($"Числа от {N} до 1: ");
Numbers(N,1);

