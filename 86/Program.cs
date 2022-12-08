// 86. Подсчитать сколько раз определенный символ (например 'a')
//встречается в строке.

int k=0;
string s=Console.ReadLine();
for(int i=0;i<s.Length;i++)
    if (s[i]=='a') k++;
System.Console.Write($"Количество символов a равно {k}"); 

