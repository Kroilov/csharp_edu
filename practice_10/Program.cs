// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа.

void TranferToArrayIf(string[] inArray, string[] outArray, int symbolLenght)
{
    int j = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
    if(inArray[i].Length <= symbolLenght)
        {
        outArray[j] = inArray[i];
        j++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


string[] inArray = new string[5] {"123", "23", "hello", "world", "res"};
string[] outArray = new string[inArray.Length];
TranferToArrayIf(inArray, outArray, 3);
Console.Write("Input array: ");
PrintArray(inArray);
Console.Write("Result: ");
PrintArray(outArray);