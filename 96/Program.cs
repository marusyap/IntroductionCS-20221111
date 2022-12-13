// 96. В двумерном массиве целых чисел. Удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.

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
    int[,] s=new int[a.GetLength(0)-1,a.GetLength(1)-1];
    int min=a[0,0];
    int k=0;
    int l=0;
    for(int i=0;i<a.GetLength(0);i++)
    {       
        for (int j=0;j<a.GetLength(1);j++)    
            if (a[i,j]<min)
                {
                    min=a[i,j];
                    l=j;
                    k=i;
                }
    }  
    for (int i=0;i<k;i++)
        {
            for (int j=0;j<l;j++)
                s[i,j]=a[i,j];
            for (int j=l+1;j<a.GetLength(1);j++)
                s[i,j-1]=a[i,j];
        }

    for (int i=k+1;i<a.GetLength(0);i++)
        {
            for (int j=0;j<l;j++)
                s[i-1,j]=a[i,j];
            for (int j=l+1;j<a.GetLength(1);j++)
                s[i-1,j-1]=a[i,j];
        }
    return s;
}

System.Console.WriteLine($"Матрица 1");

int[,] a=Random2DArray(3,3);
Print2DArray(a);
int[,] s=Change(a);
System.Console.WriteLine($"Исходная матрица");
Print2DArray(s);


