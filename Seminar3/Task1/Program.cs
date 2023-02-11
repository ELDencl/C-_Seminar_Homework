// Задача №17. Напишите программу, которая 
// принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти 
// плоскости, в которой находится эта точка.

Console.Clear();

Console.Write("Введите X: ");
int X = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine()!);

if (Y > 0)
{
    if (X > 0)
    {
        Console.WriteLine("1 четверть");
    }
    else
    {
        Console.WriteLine("2 четверть");
    }
}
else
{
    if (X > 0)
    {
        Console.WriteLine("4 четверть");
    }
    else
    {
        Console.WriteLine("3 четверть");
    }
}