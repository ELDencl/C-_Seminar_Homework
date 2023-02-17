// Задача со звездочкой. Напишите программу, которая 
// реализует обход введенного двумерного массива, 
// начиная с крайнего нижнего левого элемента против 
// часовой стрелки.
// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9


int[,] array = new int[,]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9},
};

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }   
    
}



PrintArray(array);