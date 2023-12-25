// Внутри класса Answer напишите метод PrintEvenNumbers, которая 
// на вход принимает число (number), а на выходе выводит 
// все чётные числа от 1 до number (включительно), разделеные знаком табуляции.

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 2;
while (i <= number)
{
    System.Console.Write(i + ", ");
    i = i + 2;
}
