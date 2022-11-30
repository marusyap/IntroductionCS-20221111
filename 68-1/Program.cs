/* 68-1: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] Random2DArray(int n,int m,int min=0,int max=10)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}

int[] Sum(int[,] a)
{
    int[] s=new int[a.GetLength(0)];
    s[0]=0;
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            s[i]=s[i]+a[i,j];
                      
    return s;
}
int Min(int[] s)
{
    int min=s[0];
    int k=0;
    for (int i=0;i<s.Length;i++)
    {
        if (s[i]<min)
        {
            min=s[i];
            k=i;
        }
    }
    return k;
}

int[,] a=Random2DArray(4,5);
System.Console.WriteLine($"Заданный двумерный массив");
Print2DArray(a);
int[] s=Sum(a);
int k=Min(s);
System.Console.WriteLine($"Строка с минимальной суммой номер {k}");



