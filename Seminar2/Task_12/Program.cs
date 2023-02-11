// Напишите программу, которая будет принимать на вход 2 числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит
// остаток деления
// Например:
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()!);

int ost = num1 % num2;

if (num1 % num2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {ost}");
}

// Еще один вариант решения
// Console.Clear();

// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()!);

// int ost = num1 % num2;
// if (ost == 0) Console.WriteLine("Кратно");
// else Console.WriteLine($"Не кратно, остаток {ost}");