// Задача №18. Работа в группах
// Напишите программу, которая по заданному номеру 
// четверти, показывает диапазон возможных координат 
// точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine()!);

// if (num == 1)
// {
//     Console.WriteLine("диапозон : X > 0 , Y > 0");
// }
// else if (num == 2)
// {
//     Console.WriteLine("диапозон : X < 0 , Y > 0");
// }
// else if (num == 3)
// {
//     Console.WriteLine("диапозон : X < 0 , Y < 0");
// }
// else if (num == 4)
// {
//     Console.WriteLine("диапозон : X > 0 , Y < 0");
// }
// else
// {
//     Console.WriteLine("Такой четверти не существует");
// }


switch (num)
{
    case 1:
        Console.WriteLine("диапозон : X > 0 , Y > 0");
        break;
    case 2:
        Console.WriteLine("диапозон : X < 0 , Y > 0");
        break;
    case 3:
        Console.WriteLine("диапозон : X < 0 , Y < 0");
        break;
    case 4:
        Console.WriteLine("диапозон : X > 0 , Y < 0");
        break;
    default:
        Console.WriteLine("Такой четверти не существует");
        break;


}