// 56. Написать программу копирования массива


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


int[] a=RandomIntArray(10,1,10);
System.Console.WriteLine($"Заданный массив a");
Print(a);

int[] b = (int[])a.Clone();

System.Console.WriteLine();
System.Console.WriteLine($"Исходный массив b");
Print(b);