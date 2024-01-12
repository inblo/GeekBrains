// Внутри класса Answer напишите метод FindMax, который принимает 
// на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите первое число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int Num3 = Convert.ToInt32(Console.ReadLine());

int Max = Num1;
if (Num2 > Max)
{
    Max = Num2;
}
if (Num3 > Max)
{
    Max = Num3;
    Console.WriteLine($"Максимальное число из введенных => {Max}!");
}
else if (Num1 == Num2 && Num2 == Num3)
{
    System.Console.WriteLine("Числа равны!");
}

