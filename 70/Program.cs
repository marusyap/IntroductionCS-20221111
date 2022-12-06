// 70. Показать натуральные числа от 1 до N, N задано

Console.WriteLine("Введите целое число N: ");
int N=Convert.ToInt32(Console.ReadLine());

void Numbers(int N,int i)
{
    if (i<=N)
    {
        System.Console.WriteLine(i);
        Numbers(N,i+1);
    }
}

Console.WriteLine($"Числа от 1 до {N}: ");
Numbers(N,1);
