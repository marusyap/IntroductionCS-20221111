//52. Написать программу преобразования десятичного числа в двоичное (дробные числа)

Console.WriteLine("Введите число N: ");
double N=Convert.ToDouble(Console.ReadLine());
int n=(int)Math.Truncate(N);
double m=(N-n)*2;

string DecimalToBin(int n)
{
    string s="";
    if (n==0) return "0";    
    while(n!=0)
    {        
        s=Convert.ToString(n%2)+s;
        n/=2;
    }
    return s;
}

string DoubleToBin(double m)
{
    string S="";
    int l=0;
    while(m!=0)
    {        
        if (m>=1)
        {
            m=m-1;
            S=S+Convert.ToString(1);
            m=m*2;
        }
        else
        {
            m=m*2;
            S=S+Convert.ToString(0);
        }
        l++;
        if (l>10) m=0;
    }
    return S;
}

if ((N-(int)N)==0) System.Console.WriteLine("Число "+N+" в двоичной системе счисления равно "+DecimalToBin(n));
else System.Console.WriteLine("Число "+N+" в двоичной системе счисления равно "+ DecimalToBin(n)+","+DoubleToBin(m));

