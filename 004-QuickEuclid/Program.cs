// Базовые алгоритмы:    Ускоренный алгоритм Эвклида

Console.WriteLine("Введите число a: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b=Convert.ToInt32(Console.ReadLine());

int QGCD(int a,int b)
{
    while (a!=0 && b!=0)
        if (a>b) a=a%b;
        else b=b%a;
        return a+b;
}
Console.WriteLine($"НОД чисел {a} и {b} число {QGCD(a,b)}");
