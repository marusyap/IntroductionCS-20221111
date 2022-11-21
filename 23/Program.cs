// 23. Найти расстояние между точками в пространстве 2D

Console.WriteLine("Введите координаты двух точек: ");
double x1=Convert.ToDouble(Console.ReadLine());
double y1=Convert.ToDouble(Console.ReadLine());
double x2=Convert.ToDouble(Console.ReadLine());
double y2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Раастояние между этими точками: {Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2))}");
