/* 99.  Спирально заполнить двумерный массив:
 1  2  3  4
 12 13 14  5
 11 16 15  6
 10  9  8  7 

*/

void DisplayArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            Console.Write("{0,3} ", a[i, j]);
        Console.WriteLine();
    }
}
      
Console.WriteLine("Введите целое число n: ");
int n=Convert.ToInt32(Console.ReadLine());

int[,] a = new int[n, n];
int i = 0, j = 0;
int value = 1;
           
while (n != 0)
{
    int k = 0;
    do { a[i, j++] = value++; } while (++k < n - 1);
    for (k = 0; k < n - 1; k++) a[i++, j] = value++;
    for (k = 0; k < n - 1; k++) a[i, j--] = value++;
    for (k = 0; k < n - 1; k++) a[i--, j] = value++;

    ++i; ++j; n = n < 2 ? 0 : n - 2;  
    
}       

DisplayArray(a);

        
    
