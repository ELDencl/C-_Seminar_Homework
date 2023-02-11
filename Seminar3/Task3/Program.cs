// Задача №21. Работа в группах
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09 
// ● A (7,-5); B (1,-1) -> 7,21


// Console.Clear();

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine()!);

// double qrA = Math.Pow(a, );

// Console.WriteLine(qrA);


Console.Clear();

Console.WriteLine("Введите координаты точки A: ");
Console.Write("X: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Y: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Y: ");
int y2 = int.Parse(Console.ReadLine()!);

double x3 = Math.Pow(x1 - x2, 2); //находим квадрат разницы иксов
double y3 = Math.Pow(y1 - y2, 2); //находим квадрат разницы игриков
double C = Math.Sqrt(x3 + y3); //находим корень суммы квадратов иксов и игриков


// Console.WriteLine(x3);
// Console.WriteLine(y3);
Console.WriteLine(Math.Round(C, 2)); //Просто выводим С, но ограничиваем вывод до 3 знаков после запятой с помощью Math.Round(переменная(число), колличество цифр после запятой)
Console.WriteLine($"{C:f2}"); // Другой способ вывода двух знаков после запятой
