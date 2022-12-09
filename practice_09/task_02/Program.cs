// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

int SumNumbers(int m, int n)
{
    if (m == n)
        return n;
    return n + SumNumbers(m, n - 1);
}


Console.Write("Enter M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Enter N: ");
int N = int.Parse(Console.ReadLine()!);

if (N > M)
    Console.WriteLine($"From {M} to {N} summ: {SumNumbers(M, N)}");

else
    Console.WriteLine("N must be greater than M");