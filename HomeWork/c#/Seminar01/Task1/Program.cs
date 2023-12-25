// Внутри класса Answer напишите метод CompareNumbers, который на вход принимает 
// два числа и выводит, какое число большее, а какое меньшее.

System.Console.Write("Введите первое число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

if (FirstNumber == SecondNumber)
{
    System.Console.WriteLine("Числа равны");
}

else if (FirstNumber > SecondNumber)
{
    System.Console.WriteLine("Первое число больше второго!");
}
else
{
    System.Console.WriteLine("Второе число больше первого!");
}
