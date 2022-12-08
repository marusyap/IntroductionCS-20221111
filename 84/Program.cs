/* 84. Определить являются ли введенные с клавиатуры символы
правильно записью целого числа. Вычислить сумму цифр введенного числа
*/

string s=Console.ReadLine();
int k=0;
int j=0;
 for(int i=0;i<s.Length;i++)
    if (char.IsDigit(s[i]))
    {
  //      k=k+(int)Char.GetNumericValue(s[i]);
        k=k+int.Parse(s[i].ToString());
        j++;
    }

if (j==s.Length) System.Console.WriteLine($"Сумма цифр числа {s} равна {k}");
else System.Console.WriteLine("Не число");


