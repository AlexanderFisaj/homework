/* Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

// 1-й способ решения:

/* Console.Write("Enter your number: ");
string my_number = Console.ReadLine();

int l = my_number.Length;
int n = Convert.ToInt32(my_number);
int m = 0;
int sum = 0;

for (int i = 0; i < l && n != 0; i++)
{
    m = n % 10;
    n = (n - m) / 10;
    sum = sum + m;
}

Console.WriteLine($"Summa = {sum}"); */

//2-й способ решения:

Console.Write("Enter your number: ");
int my_number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int n = my_number;

for (int i = 0; i < Convert.ToString(my_number).Length && n != 0; i++)
{
    int m = n % 10;
    n = (n - m) / 10;
    sum = sum + m;
}

Console.WriteLine($"Summa = {sum}");