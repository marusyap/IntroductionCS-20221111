// 4. По заданному с клавиатуры номеру дня недели вывести его название

Console.WriteLine("Введите целое число N от 1 до 7: ");
int N=Convert.ToInt32(Console.ReadLine());
if (N==1) Console.WriteLine($"День недели под номером {N} это понедельник");
if (N==2) Console.WriteLine($"День недели под номером {N} это вторник");
if (N==3) Console.WriteLine($"День недели под номером {N} это среда");
if (N==4) Console.WriteLine($"День недели под номером {N} это четверг");
if (N==5) Console.WriteLine($"День недели под номером {N} это пятница");
if (N==6) Console.WriteLine($"День недели под номером {N} это суббота");
if (N==7) Console.WriteLine($"День недели под номером {N} это воскресенье");
