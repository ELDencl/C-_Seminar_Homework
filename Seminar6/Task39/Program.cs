// Задача 39: Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на первом 
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}


// void ReverseArray1(int[] inArray)  // функция когда исходный массив нам больше не нужен (лучше для памяти)
// {
//     for (int i = 0; i < inArray.Length / 2; i++)  // проходы делаем до середины массива
//     {
//         int temp = inArray[i];
//         inArray[i] = inArray[inArray.Length - 1 - i];
//         inArray[inArray.Length - 1 - i] = temp;

//     }
// }


int[] ReverseArray2(int[] inArray) // второй способ, использует больше памяти, но оставляет исходный массив
{
    int[] result = new int[inArray.Length];

    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}


// для первого способа 
// int[] array = GetArray(6, 0, 10);
// Console.WriteLine(string.Join(", ", array));
// ReverseArray1(array); // мутируем массив
// Console.WriteLine(string.Join(", ", array));



int[] array = GetArray(6, 0, 10);
Console.WriteLine(string.Join(", ", array));
int[] reversed = ReverseArray2(array);
Console.WriteLine(string.Join(", ", reversed));




