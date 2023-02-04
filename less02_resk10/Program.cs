// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Enter your number: ");
double a = Convert.ToDouble(Console.ReadLine());

if (a < 0)
    a = a * -1;

while (a - (a % 1000) >= 1000 || a < 100)
{
    Console.Write("Error! !/nYou need to enter a three-digit number: ");
    a = Convert.ToDouble(Console.ReadLine());
}

a = (a - a % 10) / 10 % 10;

Console.WriteLine($"{a}");
