/* 93. Задача 93: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
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

int[,] Random22DArray(int n,int m,int min=0,int max=10)
{
    
    int[,] b=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                b[i,j]=random.Next(min,max+1);
    return b;
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

int[,] Mult(int[,] a,int[,] b)
{
    if (a.GetLength(0)!=b.GetLength(1) || a.GetLength(1)!=b.GetLength(0))
        throw new ArgumentException("Матрицы невозможно перемножить");
    int[,] s=new int[a.GetLength(0),b.GetLength(1)];
    for(int j=0;j<b.GetLength(1);j++)
        {   
            for (int k=0;k<a.GetLength(0);k++)
                {   
                    int sum=0;  
                    for(int i=0;i<a.GetLength(1);i++)
                        sum=sum+a[j,i]*b[i,k];
                    s[j,k]=sum;
                }
        }              
    return s;
}

System.Console.WriteLine($"Матрица 1");

int[,] a=Random2DArray(3,2);
int[,] b=Random22DArray(2,3);
Print2DArray(a);
System.Console.WriteLine($"Матрица 2");
Print2DArray(b);
try
{
    int[,] s=Mult(a,b);
    System.Console.WriteLine($"Исходная матрица");
    Print2DArray(s);
}
catch(Exception ex)
{
    System.Console.WriteLine(ex.Message);
}

