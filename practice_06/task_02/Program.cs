// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

using static System.Console;

double ReadFromConsole(string input)
{
    Write(input);
    return double.Parse(ReadLine());
}

double b1 = ReadFromConsole("b1 = ");
double k1 = ReadFromConsole("k1 = ");
double b2 = ReadFromConsole("b2 = ");
double k2 = ReadFromConsole("k2 = ");

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

if (k1 == k2)
    WriteLine ("No intersect");
else
    WriteLine($"Intersection point X = {x}, Y = {y}");