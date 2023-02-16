// Задача 43. Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями
//  y = k1 *  x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
// пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[] IntersectionLine(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    double[] result = new double[2];

    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("прямые совпадают");
        return result;
    }
    if (k1 == k2)
    {
        Console.WriteLine("прямые паралельны");
        return result;
    }


    // x = (b2 - b1) / (k1 - k2);
    // y = (k1 * (b2 - b1) / (k1 - k2)) + b1;
    x = ((b2 - b1) / (k1 - k2));
    y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    result[0] = x;
    result[1] = y;

    return result;
}

Console.Clear();
Console.Write("Введите значение b1 : ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k1 : ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2 : ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2 : ");
double k2 = double.Parse(Console.ReadLine()!);

double[] result = IntersectionLine(b1, k1, b2, k2);
Console.WriteLine(string.Join(", ", result));
