// 26. Найти сумму чисел от 1 до А

Console.WriteLine("Введите целое число: ");
int A=Convert.ToInt32(Console.ReadLine());

int ArProg(int x)
{
    int sum=(1+x)*x/2;  //Формула арифметической прогрессии
    return sum;
}
Console.WriteLine($"Сумма чисел от 1 до {A} равна {ArProg(A)}");


