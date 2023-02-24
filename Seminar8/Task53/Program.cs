// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку 
// массива.


int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t ");
        }
        Console.WriteLine();
    }
}


void SwapCollumn(int[,] inArray)
{
    int temp;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        temp = inArray[0, i];
        inArray[0, i] = inArray[inArray.GetLength(0) - 1, i];
        inArray[inArray.GetLength(0) - 1, i] = temp;


    }
}

Console.Clear();
int[,] Array2D = GetArray(3, 5, 0, 10);
PrintArray(Array2D);

SwapCollumn(Array2D);

Console.WriteLine();
PrintArray(Array2D);