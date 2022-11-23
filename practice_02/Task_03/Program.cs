// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Enter day number: ");
int dayN = int.Parse(Console.ReadLine());

if (dayN == 6 || dayN == 7)
    Console.WriteLine("Weekend");

    else if (dayN > 0 && dayN <6)
        Console.WriteLine("Workday");

else
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("invalid number");
    Console.ResetColor();
}