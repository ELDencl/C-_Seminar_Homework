// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int EvenNum(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element % 2 == 0)
        {
            count++;
        }
    }
    return count;
}



int[] array = GetArray(10,100,1000);
Console.WriteLine(String.Join(", ", array));

int evenNum = EvenNum(array);
Console.WriteLine(String.Join(", ", evenNum));