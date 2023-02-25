/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такой позиции в массиве нет
1 2 -> На данной позиции находиться элемент 4 */

void FillArray(int[,] array)  // Метод заполнение массива рандомными целыми числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10); // [1, 10)
    }
}

void PrintArray(int[,] array) // Метод вывод массива в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear(); // Очистка консоли
int m = new Random().Next(2, 6); // Задается рандомно количество строк в массиве
int n = new Random().Next(2, 6); // Задается рандомно количество столбцов в массиве
int[,] array = new int[m, n]; // Инициализация массива заданного размера
FillArray(array); // Заполнение массива рандомными целыми числами
Console.WriteLine("Задан массив:");
PrintArray(array); // Вывод массива в консоль
Console.WriteLine();

Console.WriteLine("Введите позицию элемента в массиве"); // запрос ввода позиции
Console.Write("(две цифры разделенные пробелом): "); // элемента в массиве
int[] position = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray(); // выборка позиции в массив
if (position[0] < m && position[1] < n) // проверка входит ли введенная позиция в наш массив
{
    Console.WriteLine($"На данной позиции находиться элемент {array[position[0], position[1]]}");
}
else Console.WriteLine("такой позиции в массиве нет");
