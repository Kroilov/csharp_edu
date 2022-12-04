// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

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

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}\t");
        }
        WriteLine();
    }
}


void FindMeanCol(int[,] inArray)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double mean = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            mean += inArray[i, j];
        }
        mean = mean / inArray.GetLength(1);
        Console.Write($"{Math.Round(mean, 2)}\t");
    }
}

Clear();
Write("Enter number of rows: ");
int rows = int.Parse(ReadLine()!);

Write("Enter number of columns: ");
int cols = int.Parse(ReadLine()!);

int[,] array = GetArrayRandom(rows, cols);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
FindMeanCol(array);