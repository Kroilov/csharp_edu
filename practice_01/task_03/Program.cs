// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

int n = int.Parse(Console.ReadLine());
int m = n % 2;
if (m == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");