// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

using static System.Console;

Write("Enter array size: ");
int size = int.Parse(ReadLine());
int[] randomArray = new int[size];

FillArrayRandom(randomArray);
PrintArray(randomArray);
Write($" -> Sum of the odd positions elements: {SearchEvenSum(randomArray)}");

void FillArrayRandom(int[] size)
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(1, 10);
    }
}

int SearchEvenSum(int[] randomArray)
{
    int sum = 0;
    for (int j = 1; j < randomArray.Length; j += 2)
    {
        sum = sum + randomArray[j];
    }
    return sum;
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
