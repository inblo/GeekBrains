// Напишите программу, которая принимает на вход
// целое число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.

int number = new Random().Next(10, 100);
int LeftDigit = number / 10;
int RightDigit = number % 10;

if (LeftDigit < RightDigit)
{
    System.Console.WriteLine($"{number} => {RightDigit}");
}
else
{
    System.Console.WriteLine($"{number} => {LeftDigit}");
}
