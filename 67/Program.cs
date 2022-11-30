// 67. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.


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

double[] Average(int[,] a)
{
    double[] s=new double[a.GetLength(0)];
    s[0]=0;
    for(int j=0;j<a.GetLength(1);j++)
    {
        for(int i=0;i<a.GetLength(0);i++)
            s[j]=s[j]+a[i,j];
        s[j]=Math.Round(s[j]/a.GetLength(0),2);
    }          
    return s;
}
                
void print(double[] s)
{
    for(int i=0;i<s.Length;i++)
        System.Console.Write($"{s[i]}  ");
}

int[,] a=Random2DArray(5,5);
System.Console.WriteLine($"Заданный двумерный массив");
Print2DArray(a);
double[] s=Average(a);
System.Console.WriteLine($"Среднее арифметическое столбцов заданной матрицы");
print(s);


