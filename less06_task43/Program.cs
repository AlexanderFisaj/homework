/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();

// запрос на ввода b1, k1, b2, k2
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

// расчет значения X
double x = Math.Round((b2 - b1) / (k1 - k2), 1);

// расчет значение Y подстановкой полученного X
double y = Math.Round(k1 * x + b1, 1);

// вывод результата на экран
Console.WriteLine($"Координаты точки пересечения: ({x};{y})");