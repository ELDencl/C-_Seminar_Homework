// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это 
// невозможно, программа должна вывести сообщение для 
// пользователя.



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



int[,] SwapRowToColumns(int[,] array)
{
    int[,] result = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result[i, j] = array[j, i];
        }
    }
    return result;

}


Console.Clear();

int[,] Array2D = GetArray(3, 5, 0, 10);
PrintArray(Array2D);

Console.WriteLine();


if (Array2D.GetLength(0) == Array2D.GetLength(1))
{
    int[,] result = SwapRowToColumns(Array2D);
    PrintArray(result);
}
else
{
    Console.WriteLine("невозможно заменить строки на столбцы");
}