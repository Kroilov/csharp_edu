// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

using static System.Console;

Write("Enter array size: ");
int size = int.Parse(ReadLine());
int[] randomArray = new int[size];

FillArrayRandom(randomArray);
PrintArray(randomArray);
Write($" -> Number of even elements: {SearchEven(randomArray)}");


void FillArrayRandom(int[] size)
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(100, 1000);
    }
}

int SearchEven(int[] randomArray)
{
    int count = 0;
    for (int j = 0; j < randomArray.Length; j++)
    {
        if (randomArray[j] % 2 == 0)
            count++;
    }
    return count;
}

void PrintArray(int[] randomArray)
{
    Write("[ ");
    for (int i = 0; i < randomArray.Length; i++)
    {
        Write(randomArray[i] + " ");
    }
    Write("]");
}


