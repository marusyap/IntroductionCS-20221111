// 61. Показать двумерный массив размером m×n заполненный
// вещественными случайными числами


double[,] Random2DArray(int n,int m)
{
    double[,] a=new double[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=Math.Round((random.NextDouble()+random.Next(1,10)),2);
    return a;
}

void Print2DArray(double[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j]} ");
           System.Console.WriteLine();
        }
}


double[,] a=Random2DArray(5,5);
System.Console.WriteLine($"Заданный двумерный массив");
Print2DArray(a);

