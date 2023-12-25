// Напишите программу, которая принимает на вход число
// и проверяет, кратно ли оно одновременно 7 и 23.

// Простое решение:
// Console.WriteLine("Введите число:  ");
// int N = Convert.ToInt32(Console.ReadLine());

// Решение с помощью метода:
int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int N = ReadInt("Введиче число: ");

if (N % 7 == 0 && N % 23 == 0)
{
    System.Console.WriteLine($"Число {N} кратно!");
}
else
{ System.Console.WriteLine($"Число {N} не кратно"); }


