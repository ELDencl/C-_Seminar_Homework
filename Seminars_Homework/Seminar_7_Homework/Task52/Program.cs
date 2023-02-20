// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом 
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого 
// столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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



double[] AverageValueColumn(double[,] array)
{
    double[] sum = new double[array.GetLength(0)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[j] += array[i,j];
        }
        
        

    }
    for (int g = 0; g < array.GetLength(0); g++)
    {
        sum[g] /= array.GetLength(1);
    }
    return sum;
}







Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

double[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);

double[] sum =AverageValueColumn(array2D);
Console.WriteLine(String.Join("; ", sum));