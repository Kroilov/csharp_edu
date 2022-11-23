// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Enter a three-digit number: ");
int a = int.Parse(Console.ReadLine());
int b = ((a / 10) % 10);

if (a < 1000 && a > 99)
    Console.WriteLine($"Second digit: {b}");

else
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("A non-three-digit number has been entered");
    Console.ResetColor();
}