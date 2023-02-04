// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число: ");
double a = Convert.ToDouble(Console.ReadLine());

if (a < 0)
    a = a * -1;

if (a > 100)
{
    a = (a - a % 100) / 100 % 10;
    Console.WriteLine($"{a}");
}    
else
    Console.WriteLine("В этом числе третьей цифры нет.");
