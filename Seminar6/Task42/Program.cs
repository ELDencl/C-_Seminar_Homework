// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


string DecToBin(int num)
{
    string result = "";
    while (num > 0)
    {
        result = (num % 2).ToString() + result;  // перобразуем переменную в строку и записываем ее в начало строки 
        num /= 2;
    }
    return result;
}







Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
// string result = DecToBin(num);
// Console.WriteLine(result);
Console.WriteLine(DecToBin(num));