/* 38. В одномерном массиве из 123 чисел найти количество
элементов из отрезка [10,99]
*/

int[] RandomIntArray(int size,int min,int max)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}


int Kol(int[] a)
{
    int k=0;
    foreach(int el in a)
        if (el>=10 && el<=99) k++;
    return k;
}




int[] a=RandomIntArray(123,0,200);
System.Console.WriteLine($"Заданный массив");
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Количество элементов из отрезка [10;99] равно {Kol(a)}");


