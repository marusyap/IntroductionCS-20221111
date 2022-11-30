// 68. Написать программу, которая обменивает элементы первой
// строки и последней строки

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

void Swap(ref int a,ref int b)
{
    int t=a;
    a=b;
    b=t;
}

int[,] Reverse(int[,] a)
{
    for(int j=0;j<a.GetLength(1);j++)
        Swap(ref a[0,j],ref a[a.GetLength(0)-1,j]);
    return a;
}
                

int[,] a=Random2DArray(5,5);
System.Console.WriteLine($"Заданный двумерный массив");
Print2DArray(a);
Reverse(a);
System.Console.WriteLine($"Исходный массив");
Print2DArray(a);





