// 35. Написать программу замены элементов массива на противоположные.

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


void Opposite(ref int a)
{
    a=a*(-1);
}

void Change(int[] a)
{
    for(int i=0;i<a.Length;i++)
     Opposite(ref a[i]);
}

//Создали массив
int[] a=RandomIntArray(10,-50,50);
System.Console.WriteLine($"Заданный массив");
Print(a);
//Обработка массива
Change(a);
System.Console.WriteLine();
System.Console.WriteLine($"Массив с противоположными элементами");
Print(a);

