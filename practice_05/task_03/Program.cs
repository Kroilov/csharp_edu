// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

using static System.Console;

Write("Enter array size: ");
int size = int.Parse(ReadLine());
double[] randomArray = new double[size];

FillArrayRandom(randomArray);
PrintArray(randomArray);
Write($" -> Difference between maximum and minimum value: {SearchMinMax(randomArray)}");

void FillArrayRandom(double[] size)
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}

double SearchMinMax(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    double diff = 0;

    for (int j = 0; j < randomArray.Length; j++)
    {
        if (randomArray[j] > max)
        {
            max = randomArray[j];
        }
        if (randomArray[j] < min)
        {
            min = randomArray[j];
        }
    }
    diff = Math.Round(max - min, 2);
    return diff;
}

void PrintArray(double[] randomArray)
{
    Write("[ ");
    for (int i = 0; i < randomArray.Length; i++)
    {
        Write(randomArray[i] + " ");
    }
    Write("]");
}