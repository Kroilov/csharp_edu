// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GetArray(int lenght, int y, int z)
{
    int[,,] resultArray = new int[lenght, y, z];
    int[] uniqueNumbers = GenerateUniqueNumbers(resultArray);
    FillArray3D(resultArray, uniqueNumbers);
    return resultArray;

}


int[] GenerateUniqueNumbers(int[,,] inArray)
{
    int[] uniqueNumbers = new int[inArray.GetLength(0) * inArray.GetLength(1) * inArray.GetLength(2)];

    for (int i = 0; i < uniqueNumbers.GetLength(0);)
    {
        int number = new Random().Next(10, 100);
        if (UniqueCheck(uniqueNumbers, number) is true)
            continue;
        uniqueNumbers[i] = number;
        i++;
    }
    return uniqueNumbers;
}


bool UniqueCheck(int[] array, int number)
{
    bool flag = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] == number)
        {
            flag = true;
        }
    }
    return flag;
}


int[,,] FillArray3D(int[,,] array, int[] numbers)
{
    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = numbers[count];
                count++;
            }
        }
    }
    return array;
}


void PrintPosition(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.WriteLine($"{array[x, y, z]} ({x}, {y}, {z})");
            }
        }
    }
}


int[,,] array3D = GetArray(3, 3, 3);
PrintPosition(array3D);