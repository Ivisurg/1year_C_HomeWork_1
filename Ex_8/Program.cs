// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число больше 1: ");
string inputValue = Console.ReadLine();

int value = Convert.ToInt32(inputValue);
if (value > 1)
{
    int count = 2;
    while (count <= value)
    {
        System.Console.Write(count + " ");
        count += 2;
    }
}
else
    {
        System.Console.WriteLine("Введенное число не больше 1. Перезапустите программу");
    }
