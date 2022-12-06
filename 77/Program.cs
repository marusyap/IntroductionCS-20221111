/* 77. Написать программу показывающие первые N чисел, для которых
каждое следующее равно сумме двух предыдущих. Первые два элемента
последовательности 0 и 1
*/

Console.WriteLine("Введите целое число N: ");
int N=Convert.ToInt32(Console.ReadLine());

int Numbers(int N)
{
    
        if (N==0) return 0;
        if (N==1) return 1;
        return Numbers(N-2)+Numbers(N-1);
        
}
Console.WriteLine($"Числа Фибоначчи до {N}: ");
for (int i=0;i<=N;i++)
    Console.WriteLine(Numbers(i));




