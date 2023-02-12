// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



// double[] GetDobleArray(int size)
// {
//     double[] result = new double[size];

//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().NextDouble();
//         result[i] = result[i] * 100;

//     }
//     return result;
// }


double[] boobs(int size, int minValue, int maxValue) //другое решение более лаконичное 
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue +1); // создаем число в полуинтервале
        result[i] += Math.Round(new Random().NextDouble(), 2); // прибавляем к созданному числу остаток от 0 до 1.0 
    } //Math.Round(bla bla bla , 2) округляет число до 2 знаков после точки
    return result;
}



double DifNum(double[] array)
{
    double dif = Math.Round(array[array.Length - 1] - array[0], 2);
    if (dif < 0)
    {
        dif *= -1; // находим разницу по модулю 
    }

    return dif;
}




double[] array = boobs(4,0,10);
Console.WriteLine(string.Join(", ", array));

double dif = DifNum(array);
Console.WriteLine(dif);







