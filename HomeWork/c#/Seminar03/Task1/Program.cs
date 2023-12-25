// Задача 1
// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] array = new int[10];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(1, 101);
int count = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i] >= 20 && array[i] < +90)
        count++;

Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Количество элементов в диапазоне от 20 до 90 => {count}");


