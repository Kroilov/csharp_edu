// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

int SumRowElements(int[,] array, int i)
{
    int sumRow = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumRow += array[i, j];
    }
    return sumRow;
}

int FindSmallRow(int[,] array)
{
    int minSumRow = 0;
    int sumRow = SumRowElements(array, 0);
    WriteLine($"\nRow 0 sum: {sumRow}");
    for (int k = 1; k < array.GetLength(0); k++)
    {
        int tempSumRow = SumRowElements(array, k);
        WriteLine($"Row {k} sum: {tempSumRow}");
        if (sumRow > tempSumRow)
        {
            sumRow = tempSumRow;
            minSumRow = k;
        }
    }
    return minSumRow;
}

int[,] array = GetArrayRandom(5, 5);
WriteLine($"Generated array:");
PrintArray(array);
Console.WriteLine($"\nRow with the smallest sum of elements: {FindSmallRow(array)}");
