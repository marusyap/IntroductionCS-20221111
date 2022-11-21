/* 31. Сгенерировать 10 случайных чисел. Показать кубы тех чисел,
которые заканчиваются на четную цифру.
*/


Random random=new Random();
for (int i=0;i<10;i++)
{
    int a=random.Next(1,100);
    if (Math.Pow(a,3)%2==0)
    {
    int b=(int)Math.Pow(a,3);
    Console.WriteLine($"{a} {b}");
    }
}

