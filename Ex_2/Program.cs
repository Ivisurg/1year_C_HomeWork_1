// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число > ");
string inputValue1 = Console.ReadLine();

Console.Write("Введите второе число > ");
string inputValue2 = Console.ReadLine();

int value1 = Convert.ToInt32(inputValue1);   //переводим первое число в целочисленное значение
int value2 = Convert.ToInt32(inputValue2);   //переводим второе число в целочисленное значение

if (value1>value2)
{
    System.Console.WriteLine($"Число {value1} - большее, а число {value2} - меньшее");
}
else
{
    System.Console.WriteLine($"Число {value2} - большее, а число {value1} - меньшее");
}
