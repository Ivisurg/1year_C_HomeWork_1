// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите первое число: ");
string inputValue1 = Console.ReadLine();

System.Console.WriteLine("Введите второе число: ");
string inputValue2 = Console.ReadLine();

System.Console.WriteLine("Введите третье число: ");
string inputValue3 = Console.ReadLine();

int value1 = Convert.ToInt32(inputValue1),
    value2 = Convert.ToInt32(inputValue2),
    value3 = Convert.ToInt32(inputValue3);

if (value1 >= value2 && value1 >= value3)
{
    System.Console.WriteLine($"Максимальное число из {value1}, {value2} и {value3} - число {value1}");
}
else if (value2 >= value1 && value2 >= value3)
    {
        System.Console.WriteLine($"Максимальное число из {value1}, {value2} и {value3} - число {value2}");
    }
    else
    {
        System.Console.WriteLine($"Максимальное число из {value1}, {value2} и {value3} - число {value3}");
    }
