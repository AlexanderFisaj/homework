/* Задача 25: 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Нельзя использовать Math.Pow();
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень, в которую нужно возвести Ваше число: ");
int b = Convert.ToInt32(Console.ReadLine());

int rez = 1;

if (b == 0) rez = 1;

for (int i = 0; i < b; i++)
{
    rez = rez * a;
}

Console.WriteLine($"Результат = {rez}");
