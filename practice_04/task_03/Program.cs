//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using static System.Console;

void PrintArray(int[] arg)
{
    string result = "[";
    for (int i = 0; i < arg.Length; i++)
        result = result + arg[i] + ", ";
    result = result.Substring(0, result.Length - 2);
    result = result + "]";
    Console.WriteLine(result);
}

int[] arr = new int[8];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
    arr[i] = rand.Next(0, 10);

PrintArray(arr);