/* Задача 38: Задайте массив вещественных(дробных) чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.1, 7.23, 22.57, 2.45, 78.78] -> 76.33 */

Console.Clear();

// формирование массива в ручном режиме
Console.WriteLine("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите чесло - {n} раз(а).");
double[] array = new double[n];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i}-й элемент: ");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

// Выборка максимального и минимального значений
double max = array[0];
double min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (max < array[i]) max = array[i];
    else if (min > array[i]) min = array[i];
}

Console.WriteLine($"Разница между максимальным и минимальным числом = {max - min}");