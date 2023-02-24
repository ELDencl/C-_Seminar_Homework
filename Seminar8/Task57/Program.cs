// Задача 57: Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит 
// информацию о том, сколько раз встречается элемент 
// входных данных.


// Набор данных                                                  Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза               1 встречается 1 раз 
//                                                               2 встречается 1 раз
//                                                               8 встречается 1 раз 
//                                                               9 встречается 3 раза



// 1, 2, 3                                                       1 встречается 3 раза 
// 4, 6, 1                                                       2 встречается 2 раз 
// 2, 1, 6                                                       3 встречается 1 раз
//                                                               4 встречается 1 раз
//                                                               6 встречается 2 раза




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

int[] Convert2DTo1D(int[,] array)
{
    int[] result = new int[array.GetLength(0) * array.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[k] = array[i, j];
            k++;
        }
    }
    return result;
}

void BubleSortArray(int[] Array)
{
    int temp;

    for (int i = 0; i < Array.Length - 1; i++)
    {
        for (int j = i + 1; j < Array.Length; j++)
        {
            if (Array[i] > Array[j])
            {
                temp = Array[i];
                Array[i] = Array[j];
                Array[j] = temp;
            }
        }
    }
}

void PrintCountEllementInArray(int[] array)
{
    int count = 1;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == array[i - 1])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{array[i-1]} встречается {count} раз");
            count = 1;
        }
    }
    Console.WriteLine($"{array[array.Length - 1]} встречается {count} раз");
}

Console.Clear();
int[,] array2D = GetArray(5,5,0,10);
PrintArray(array2D);

int[] convertArray = Convert2DTo1D(array2D);
Console.WriteLine(String.Join(", ", convertArray));
BubleSortArray(convertArray);
PrintCountEllementInArray(convertArray);
