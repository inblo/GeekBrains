// Напишите программу, которая принимает на вход координаты
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер 
// координатной четверти плоскости, в которой находится эта точка.

System.Console.Write("Введите координаты Х: ");
int X = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    System.Console.WriteLine($"{X}, {Y} => 1");
}
if ((X < 0 && Y > 0))
{
    System.Console.WriteLine($"{X}, {Y} => 2");
}
if ((X < 0 && Y < 0))
{
    System.Console.WriteLine($"{X}, {Y} => 3");
}
if ((X > 0 && Y < 0))
{
    System.Console.WriteLine($"{X}, {Y} => 4");
}
System.Console.WriteLine();

