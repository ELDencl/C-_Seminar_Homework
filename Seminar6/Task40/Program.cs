// Задача 40: Напишите программу, которая принимает на вход три 
// числа и проверяет, может ли существовать треугольник с сторонами 
// такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.



// Console.Write("Введите первую сторону: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите вторую сторону: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите первую сторону: ");
// int a = int.Parse(Console.ReadLine()!);


bool CheckTrine(int a, int b, int c)
{
    return a + b > c && a + c > b && b + c > a; // оператор сравнения все равно выдает (true или false) , так можем записать в одну строку
    // if (a + b > c && a + c > b && b + c > a)
    // {
    //     return true;
    // }
    // return false;
}



Console.Write("Введите первую сторону: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите вторую сторону: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите третью сторону: ");
int z = int.Parse(Console.ReadLine()!);

if (CheckTrine(x,y,z))
{
    Console.WriteLine("такой треугольник существует");
}
else
{
    Console.WriteLine("такой треугольник не существует");
}