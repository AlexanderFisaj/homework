/* Транспонирование - 4

Задана целочисленная матрица, состоящая из N строк и M столбцов. 
Требуется транспонировать ее относительно горизонтали.

Входные данные
Первая строка входного файла INPUT.TXT содержит два натуральных числа N и M – 
количество строк и столбцов матрицы. В каждой из последующих N строк записаны M целых чисел – 
элементы матрицы. Все числа во входных данных не превышают 100 по абсолютной величине.

Выходные данные
В выходной файл OUTPUT.TXT выведите матрицу, полученную транспонированием исходной матрицы 
относительно горизонтали.
 */

void FillArray(int[,] array)  // Метод заполнение массива рандомными целыми числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10); // [1, 10)
    }
}

void PrintArray(int[,] array) // Метод вывод 2-мерного массива в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}

void TransponirArray (int[,] array) // Метод транспорнирования
{
    int temp = 0;
    int length = array.GetLength(0) / 2;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < length; j++)
        {
            temp = array[j, i];
            array[j, i] = array[array.GetLength(0) - 1 - j, i];
            array[array.GetLength(0) - 1 - j, i] = temp;  
        }                  
    }
}

Console.Clear(); // Очистка консоли
int m = new Random().Next(2, 6); // Задается рандомно количество строк в массиве
int n = new Random().Next(2, 6); // Задается рандомно количество столбцов в массиве
int[,] dualArray = new int[m, n]; // Инициализация 2-мерного массива заданного размера


FillArray(dualArray); // Заполнение массива рандомными целыми числами
Console.WriteLine("Задан массив:");
PrintArray(dualArray); // Вывод 2-мерного массива в консоль
Console.WriteLine();

TransponirArray(dualArray); // Передача массива методу для транспонирования по горизонтали
Console.WriteLine("Транспонированный массив:");
PrintArray(dualArray); // Вывод 2-мерного массива в консоль
