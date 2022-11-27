// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

using static System.Console;

int ReadConsole(string input)
{
    Write(input);
    return int.Parse(ReadLine());
}

WriteLine("Enter first coordinates:");
int x1 = ReadConsole("x(1) = ");
int y1 = ReadConsole("y(1) = ");
int z1 = ReadConsole("z(1) = ");

WriteLine("Enter second coordinates:");
int x2 = ReadConsole("x(2) = ");
int y2 = ReadConsole("y(2) = ");
int z2 = ReadConsole("z(2) = ");

double distance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

WriteLine($"Distance {distance(x1, x2, y1, y2, z1, z2)}");