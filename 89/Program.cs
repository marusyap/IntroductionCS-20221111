// 89. Подсчитать сумму цифр, встречающихся в строке

string s=Console.ReadLine();
int k=0;
for(int i=0;i<s.Length;i++)
    if (char.IsDigit(s[i])) k=k+int.Parse(s[i].ToString());
System.Console.WriteLine(k);    


