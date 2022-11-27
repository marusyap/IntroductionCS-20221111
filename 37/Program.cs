/* 37. Задать массив, заполнить случайными положительными трёхзначными числами.
Показать количество нечетных\четных чисел
*/

int[] RandomIntArray(int size,int min,int max)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

int SumOdd(int[] a)
{
    int k=0;
    foreach(int el in a)
        if (el%2!=0) k++;
    return k;
}

int SumNotOdd(int[] a)
{
    int k=0;
    foreach(int el in a)
        if (el%2==0) k++;
    return k;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

System.Console.WriteLine($"Заданный массив");
int[] a=RandomIntArray(12,100,999);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Количество нечетных элементов {SumOdd(a)}");
System.Console.WriteLine($"Количество четных элементов {SumNotOdd(a)}");
