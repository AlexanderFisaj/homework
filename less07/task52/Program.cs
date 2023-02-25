/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


void FillArray(int[,] array)  // Метод заполнение массива рандомными целыми числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10); // [1, 10)
    }
}

void PrintDualArray(int[,] array) // Метод вывод 2-мерного массива в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}

void PrintArray(double[] array) // Метод вывод массива в консоль
{
        for (int j = 0; j < array.Length; j++)
            Console.Write($"{array[j]}; ");        
}

double MeanArithmeticCall (int[,] array, int numberCall) // Метод расчета среднего арифметического столбца
{
    double result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result = result + array[i, numberCall];
    }
    result = result / array.GetLength(0);
    return result;
}

Console.Clear(); // Очистка консоли
int m = new Random().Next(2, 6); // Задается рандомно количество строк в массиве
int n = new Random().Next(2, 6); // Задается рандомно количество столбцов в массиве
int[,] dualArray = new int[m, n]; // Инициализация 2-мерного массива заданного размера
double[] arrayMeans = new double[n]; // Инициализация массива средних арифметических

FillArray(dualArray); // Заполнение массива рандомными целыми числами
Console.WriteLine("Задан массив:");
PrintDualArray(dualArray); // Вывод 2-мерного массива в консоль
Console.WriteLine();

// Вычисление среднего арифметического каждого столбца
for (int j = 0; j < dualArray.GetLength(1); j++) 
{
    arrayMeans[j] = MeanArithmeticCall(array: dualArray, numberCall: j);
}
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(arrayMeans); // Вывод массива результатов вычислений в консоль
