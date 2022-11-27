/* 33. Задать массив из 8 элементов, заполненных нулями и единицами.
Вывести их на экран
*/

int[] RandomIntArray(int size,int min,int max)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

System.Console.WriteLine($"Заданный массив");
void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] a=RandomIntArray(8,0,1);
Print(a);



