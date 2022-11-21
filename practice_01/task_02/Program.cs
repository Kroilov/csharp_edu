// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());
Console.Write("с = ");
int c = int.Parse(Console.ReadLine());

int nmax = a;
if (b > a)
    nmax = b;
if (c > nmax)
    nmax = c;

Console.WriteLine($"max = {nmax}");