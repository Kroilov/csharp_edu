// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Ackerman(int M, int N)
{
    if (M == 0)
        return N + 1;
    else if (N == 0) 
        return Ackerman(M - 1, 1);
    else 
        return Ackerman(M - 1, Ackerman(M, N - 1));
}


Console.Write("Enter M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Enter N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"A({M},{N}) = {Ackerman(M, N)}");