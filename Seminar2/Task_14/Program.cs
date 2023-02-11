// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// • 14 -> нет 
// • 46 -> нет 
// • 161 -> да

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num % 7 == 0)
{
    if(num % 23 == 0)
    {
        Console.WriteLine($"ДА, число {num} одновременно кратно 7 и 23");
    }
    else 
    {
        Console.WriteLine($"НЕТ, число {num} одновременно не кратно 7 и 23");
    }
}
else
{
    Console.WriteLine($"НЕТ, число {num} одновременно не кратно 7 и 23");
}





// Другое решение :
// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);

// if (num % 7 == 0 && num % 23 == 0)
// {
//     Console.WriteLine($"ДА, число {num} одновременно кратно 7 и 23");
// }
// else
// {
//     Console.WriteLine($"НЕТ, число {num} одновременно не кратно 7 и 23");
// }
