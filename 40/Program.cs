/* 40. Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10.
Создайте массив, который является произведением пар чисел в одномерном массиве a.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
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




int[] Change(int[] a)

{
    int[] b=new int[a.Length/2];
    for(int i=0;i<a.Length/2;i++)
        b[i]=a[i]*a[a.Length-i-1];
    return b;
}

void print(int[] b)
{
    for(int i=0;i<b.Length;i++)
        System.Console.Write($"{b[i],5}");
}

//Создали массив
int[] a=RandomIntArray(10,1,10);
System.Console.WriteLine($"Заданный массив");
Print(a);
//Обработка массива
int[] b=Change(a);
System.Console.WriteLine();
System.Console.WriteLine($"Исходный массив");
print(b);

