// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("N = ");
int N = int.Parse(Console.ReadLine());

for (int i = 2; i <= N; i += 2) 
{
    System.Console.WriteLine(i);
}