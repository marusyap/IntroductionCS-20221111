// Обмен значениями двух переменных классический способ
int a=5;
int b=7;
int temp=a;
a=b;
b=temp;
Console.WriteLine($"a={a} b={b}");

/* Без использование переменной
int a=5;
int b=7;
a=a+b;
b=a-b;
a=a-b;
*/

/*
int a=5;
int b=7;
a=a^b;
b=a^b;
a=a^b;
Console.WriteLine($"a={a} b={b}");
*/
