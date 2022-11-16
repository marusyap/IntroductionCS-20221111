/* Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y 
!(X || Y)==!X && !Y
*/

Console.WriteLine("X Y ¬(X || Y) = ¬X && ¬Y");
Console.WriteLine($"0 0 {Convert.ToInt32(!(false || false)),5} {Convert.ToInt32(!false && !false),8}");
Console.WriteLine($"0 1 {Convert.ToInt32(!(false || true)),5} {Convert.ToInt32(!false && !true),8}");
Console.WriteLine($"1 0 {Convert.ToInt32(!(true || false)),5} {Convert.ToInt32(!true && !false),8}");
Console.WriteLine($"1 1 {Convert.ToInt32(!(true || true)),5} {Convert.ToInt32(!true && !true),8}");

