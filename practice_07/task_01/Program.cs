//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using static System.Console;

double[,] GetArrayRandom(int m, int n)
{
    double[,] randomArray = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            randomArray[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return randomArray;
}

void PrintArray(double[,] inArray)
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

Write("Enter number of rows: ");
int rows = int.Parse(ReadLine()!);

Write("Enter number of columns: ");
int cols = int.Parse(ReadLine()!);

double[,] array = GetArrayRandom(rows, cols);
Console.WriteLine();
PrintArray(array);

