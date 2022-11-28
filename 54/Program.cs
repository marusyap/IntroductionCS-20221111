/* 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
*/

Console.WriteLine("Введите целое число N: ");
int N=Convert.ToInt32(Console.ReadLine());
int[] t;
t=new int[N];
t[0]=0;
t[1]=1;
for(int i=2;i<t.Length;i++)
    t[i]=t[i-2]+t[i-1];

Console.WriteLine("Первые {N} чисел Фибоначчи ");
void Print(int[] t)
{
    for(int i=0;i<t.Length;i++)
        System.Console.Write($"{t[i]} ");
}

Print(t);




