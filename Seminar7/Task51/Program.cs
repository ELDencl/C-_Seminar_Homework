// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с 
// индексами (0,0); (1;1) и т.д.

// Например, задан массив:                            cумма элементов главной
// 1 4 7 2                                            диагонали: 1+9+2 = 12
// 5 9 2 3
// 8 4 2 4


Console.Clear();
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


int DiogonalSum(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                result += array[i, j];
            }
        }
    }
    return result;
}

// ОТИМИЗИРОВАННОЕ решение
// int DiogonalSum(int[,] array)
// {
//     int size = array.GetLength(0) > array.GetLength(1)? array.GetLenght(1): array.GetLength(0);
//     int result = 0;
//     for (int i = 0; i < size; i++)
//     {
//         result += array[i, i];
//     }
   
//     return result;
// }

void PrintArray(int[,] inArray)
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

int[,] array = GetArray(row, col, 0, 10);
PrintArray(array);

Console.WriteLine("+++++++++++++++++++++");

int sum = DiogonalSum(array);
Console.WriteLine($"Сумма диагонали массива равна {sum}");