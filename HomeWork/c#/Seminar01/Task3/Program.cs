// Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0)
{
    System.Console.WriteLine($"Число {number} четное!");
}
else 
{
    System.Console.WriteLine($"число {number} не четное!");
}
