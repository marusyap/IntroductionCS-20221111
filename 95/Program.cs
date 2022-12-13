/* 95. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/

int[,,] Random2DArray(int n,int m,int l,int min=10,int max=99)
{
    int[,,] a=new int[n,m,l];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
            for(int k=0;k<l;k++)
                a[i,j,k]=random.Next(min,max+1);
    return a;
}

void Print2DArray(int[,,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        for(int k=0;k<a.GetLength(2);k++)
            System.Console.Write($"{a[i,j,k]}({i},{j},{k}) ");
        }
}

int[,,] a=Random2DArray(2,2,2);
System.Console.WriteLine($"Заданный двумерный массив");
Print2DArray(a);