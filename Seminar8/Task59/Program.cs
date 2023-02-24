// Задача 59: Задайтедвумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на 
// пересечении которых расположен наименьший элемент 
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7


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


int[] MinEllementInArray2D(int[,] array)
{
    int minrow = 0;
    int mincol = 0;
    int min = array[0, 0];
    // int[] result = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                minrow = i;
                mincol = j;
            }


        }
    }
    // result = new int[] { minrow, mincol };
    // return result;

    return new int[] { minrow, mincol };


}


int[,] DeleteArray(int[,] array, int[] minIndexes)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int row = 0;
    int col = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == minIndexes[0]) continue;
        for (int j = 0; j < array.GetLength(1) ; j++)
        {
            if (j != minIndexes[1])
            {
                result[row, col] = array[i, j];
                col++;


            }
           

        }
        col = 0;
        row++;
    }
    return result;

}


Console.Clear();
int[,] Array2D = GetArray(5, 5, 0, 10);
PrintArray(Array2D);

Console.WriteLine();

int[] minPosition = MinEllementInArray2D(Array2D);
int[,] newArray = DeleteArray(Array2D, minPosition);

PrintArray(newArray);


