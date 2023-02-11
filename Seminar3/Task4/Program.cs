// Задача №22. Общее обсуждение
// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4


Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;

// while (count <= N)
// {
//     double sqrN = Math.Pow(count, 2);
//     Console.Write($"{sqrN} "); 
//     count++;
// }

while (count <= N)    //ТА же запись, но ставит запятую после каждого вывода числа
{
    double sqrN = Math.Pow(count, 2);
    Console.Write(sqrN);
    if (count != N)
    {
        Console.Write(", ");
    } 
    count++;
}