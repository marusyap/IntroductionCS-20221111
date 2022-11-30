// 64. В двумерном массиве заменить элементы, у которых оба индекса
// чётные на их квадраты по значению.

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

int[,] Change(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        if (i%2==0 && j%2==0) a[i,j]=(int)Math.Pow(a[i,j],2);
        }
    return a;
}

int[,] a=Random2DArray(5,5);
System.Console.WriteLine($"Заданный двумерный массив");
Print2DArray(a);
Change(a);
System.Console.WriteLine($"Исходный массив");
Print2DArray(a);


