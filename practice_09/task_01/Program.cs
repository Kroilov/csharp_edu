// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

string PrintNumber(int N)
{
    if (N == 1) return N.ToString();
    return (N + " " + PrintNumber(N - 1));
}


Console.Write("Enter number: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write(PrintNumber(N));
