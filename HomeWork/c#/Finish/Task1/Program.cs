﻿// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

int InputNumber(string text)
{
    do{
        Console.Write(text);
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0)
            return index;
        else
             Console.WriteLine("Некорректный ввод. Введите положительное целое число."); 
    } while (true);
}

void ShowRealNumbers(int volumeM, int volumeN)
{   
    if (volumeM <= volumeN)
    {
        Console.Write(volumeM == volumeN ? volumeM : volumeM + ", ");
        ShowRealNumbers(volumeM + 1, volumeN);
    }
}

int numberM = InputNumber("Введите число M: ");
int numberN = InputNumber("Введите число N: ");
Console.Write($"M = {numberM}; N = {numberN} => \"");
ShowRealNumbers(numberM, numberN);
Console.WriteLine("\"");
