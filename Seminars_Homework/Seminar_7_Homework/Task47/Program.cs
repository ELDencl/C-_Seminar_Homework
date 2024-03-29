﻿// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.Clear();
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    double rem = 0;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            rem =  Math.Round(new Random().NextDouble(),2);
            result[i, j] = new Random().Next(minValue, maxValue + 1) + rem;
        }
    }
    return result;
}



void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t "); // \t табуляция (escape последовательсность) выравнивает столбцы 
        }
        Console.WriteLine();
    }
}



Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

double[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);