// Задача 19. Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

using static System.Console;

Write("Enter a five-digit number: ");
string number = ReadLine();

void Сheck(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
        WriteLine("Yes");
    else
        WriteLine("No");
}

if (number.Length == 5)
    Сheck(number);
else
    WriteLine("Incorrect number");