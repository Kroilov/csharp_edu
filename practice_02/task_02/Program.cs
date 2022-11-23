// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Enter number: ");
int a = int.Parse(Console.ReadLine());
string astring = Convert.ToString(a);

if (astring.Length > 2)
    Console.WriteLine ($"Third digit: " + astring[2]);

else
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine ("Less than three digits has been entered");
    Console.ResetColor();
}