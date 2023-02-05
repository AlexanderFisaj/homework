/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

int i = 0;
Console.Write("Введите число: ");
string numbers = Console.ReadLine();
// проверка числа на пятизначность и повтор ввода если число проверку не прошло
while (numbers.Length != 5)
{
    Console.Write("Введено не правилное число. \nПовторите ввод: ");
    numbers = Console.ReadLine();
}
if (numbers[i] == numbers[numbers.Length-1] && numbers[i+1] == numbers[numbers.Length-2])
    Console.WriteLine($"ДА! Число {numbers} является полиндромом.");
else
    Console.WriteLine($"НЕТ! Число {numbers} НЕ является полиндромом.");
