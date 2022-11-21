// Базовые алгоритмы:    Алгоритм Эвклида

Console.WriteLine("Введите число a: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b=Convert.ToInt32(Console.ReadLine());

int GCD(int a,int b)
{
    while (a!=b)
        if (a>b) a=a-b;
        else b=b-a;
        return a;
}
Console.WriteLine($"НОД чисел {a} и {b} число {GCD(a,b)}");
