// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

using static System.Console;

Write("Enter number: ");
int number = int.Parse(ReadLine());

int numberSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
WriteLine($"Sum: {numberSum(number)}");