// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = new int[10];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 101);
}
int count = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
    {
        count++;
    }
Console.WriteLine("[" + string.Join(",", array) + "]");
Console.WriteLine($"Количество четных элементов в массиве => {count}");

