/* Суперсдвиг
Дана последовательность из N целых чисел и число K. 
Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, 
если K – положительное и влево, если отрицательное.

Входные данные
Первая строка входного файла INPUT.TXT содержит натуральное число N, 
во второй строке записаны N целых чисел Ai, а в последней – целое число K. 
(1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).

Выходные данные
В выходной файл OUTPUT.TXT выведите полученную последовательность. */

Console.Clear();

// Запрос на ввод размера массива
Console.Write("Введите количество целых чисел в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

// Заполнение массива рандомными числами и вывод его в консоль
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 106); // [1, 105]
    
Console.WriteLine($"[{string.Join(", ", array)}]");

// Запрос ввода числа смещения
Console.Write("Введите число для смещения: ");
int k = Convert.ToInt32(Console.ReadLine());

int[] new_array = new int[n];

int start = 0;

// Определение точки отсчета
if (k < 0) start = k * (-1);
else start = array.Length - k;

// Формирование смещенного массива
int l = start;
for (int i = 0; l < array.Length; i++)
    {
        new_array[i] = array[l];
        l++;
    }

int j = array.Length - start;
for (int i = 0; j < new_array.Length; i++)
    {
        new_array[j] = array[i];
        j++;
    }

// Вывод смещенного массива
Console.WriteLine($"[{string.Join(", ", new_array)}]");
