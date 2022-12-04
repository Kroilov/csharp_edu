// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using static System.Console;

int[,] GetArrayRandom(int m, int n)
{
    int[,] randomArray = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            randomArray[i, j] = new Random().Next(0, 10);
        }
    }
    return randomArray;
}

int[,] array = GetArrayRandom(5, 5);

Write("Row: ");
int row = int.Parse(ReadLine()!);

Write("Column: ");
int col = int.Parse(ReadLine()!);

if ((row < array.GetLength(0)) && (col < array.GetLength(1)))
{
    WriteLine($"Element value: {array[row, col]}");
}
else
{
    WriteLine("There is no such element");
}