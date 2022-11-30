// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

using static System.Console;

int ReadFromConsole(string input)
{
    Write(input);
    return int.Parse(ReadLine());
}

int a = Convert.ToInt32(ReadFromConsole("a = "));
int b = Convert.ToInt32(ReadFromConsole("b = "));

//double power = Math.Pow(a,b);

int power(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
        result = result * a;
    return result;
}
WriteLine($"Answer: {power(a, b)}");