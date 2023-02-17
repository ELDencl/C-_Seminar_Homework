




double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}


// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine(Factorial(i));
// }

// Console.WriteLine(Factorial(5)); // 1*2*3 = 6

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}



// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) +f(n-2)



double Fibonachy(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonachy(n - 1) + Fibonachy(n - 2);
}


for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i} = {Fibonachy(i)}");
}