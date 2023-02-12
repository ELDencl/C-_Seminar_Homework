// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



double[] GetDobleArray(int size)
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble();
        result[i] = result[i] * 100;

    }
    return result;
}


double DifNum(double[] array)
{
    double dif = array[array.Length - 1] - array[0];
    if (dif < 0)
    {
        dif *= -1; // находим разницу по модулю 
    }
    return dif;
}




double[] array = GetDobleArray(4);
Console.WriteLine(string.Join(", ", array));

double dif = DifNum(array);
Console.WriteLine(dif);









