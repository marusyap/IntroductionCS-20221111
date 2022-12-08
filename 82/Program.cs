/* 82. C клавиатуры вводится строка разделенная точкой.
Подсчитать количество символов до точки
*/

int k=0;
string s=Console.ReadLine();
for(int i=0;i<s.IndexOf(".");i++)
   // System.Console.Write(s[i]);
   k++;
System.Console.Write($"Количество символов до . {k}"); 

