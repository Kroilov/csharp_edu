// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N

using static System.Console;

Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

void cube(int[] number)
{
    for (int counter = 1; counter < number.Length; counter++)
    {
        number[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        WriteLine(number[counter]);
    }
}

int[] resultArray = new int[number + 1];
cube(resultArray);