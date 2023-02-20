// Задача 49: Задайте двумерный массив. Найдите элементы, у 
// которых оба индекса чётные, и замените эти элементы на их 
// квадраты.
// Например, изначально массив          Новый массив будет выглядеть     
//  выглядел вот так:                   вот так:
// 1 4 7 2                              1 4 49 2
// 5 9 2 3                              5 81 2 9
// 8 4 2 4                              64 4 4 4

Console.Clear();
int[,] GetArray(int m, int n, int minValue, int maxValue)   // функция для инициализации массива с случайными числами
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



void PrintArray(int[,] inArray) // функция для распечатывания массива в консоли
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


void ArrayPow(int[,] Array)  // функция которая возводит число в квадрат, если индексы четные 
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                Array[i, j] *= Array[i, j];
            }
        }
    }
}


// ОПТИМИЗИРОВАННЫЙ вариант 
// void ArrayPow(int[,] Array)  // функция которая возводит число в квадрат, если индексы четные 
// {
//     for (int i = 0; i < Array.GetLength(0); i += 2)
//     {
//         for (int j = 0; j < Array.GetLength(1); j += 2)
//         {
//             Array[i, j] *= Array[i, j];
//         }
//     }
// }       




Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] result = GetArray(row, col, 0, 10);
Console.WriteLine("Изначальный массив: ");
PrintArray(result);
ArrayPow(result);

Console.WriteLine();
Console.WriteLine("Измененный массив: ");
PrintArray(result);