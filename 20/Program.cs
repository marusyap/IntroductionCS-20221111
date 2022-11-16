/* Определить номер четверти плоскости, в которой находится точка
с координатами Х и У, причем X ≠ 0 и Y ≠ 0
*/


double x;
double y;
do
{
    Console.WriteLine("Введите координаты точки x и y (x и y не равны 0): ");
    x=Convert.ToDouble(Console.ReadLine());
    y=Convert.ToDouble(Console.ReadLine());
}
while (x==0 || y==0);
if (x>0 && y>0) Console.WriteLine($"Точка ({x},{y}) находится в I четверти");
if (x>0 && y<0) Console.WriteLine($"Точка ({x},{y}) находится в IV четверти");
if (x<0 && y>0) Console.WriteLine($"Точка ({x},{y}) находится в II четверти");
if (x<0 && y<0) Console.WriteLine($"Точка ({x},{y}) находится в III четверти");

