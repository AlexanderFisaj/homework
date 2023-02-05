/* Второй максимум
(Время: 1 сек. Память: 16 Мб Сложность: 16%)
Задана последовательность натуральных чисел, завершающаяся числом 0. 
Требуется определить значение второго по величине элемента в этой последовательности, 
то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.

Входные данные
Входной файл INPUT.TXT содержит последовательность неотрицательных целых чисел, не превышающих значения 100. 
Гарантируется, что во входных данных не более 100 чисел и среди них есть хотя бы одно число 0, перед которым идет как минимум 2 элемента.

Выходные данные
В выходной файл OUTPUT.TXT выведите целое число – значение второго максимума. */

Console.WriteLine($"Введите последовательность чисел \n(минимальное количество 2 без учета нуля). \nЗавершите ввод нулем.");
Console.WriteLine();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

while (n == 0)
{
    Console.WriteLine($"Это число не может быть нулем! \nПовторите ввод!");
    Console.Write("Введите число: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
}


Console.Write("Введите следующее число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

while (m == 0)
{
    Console.WriteLine($"Это число не может быть нулем! \nПовторите ввод!");
    Console.Write("Введите следующее число: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
}

int maxim = n;
int next_maxim = 0;

while (m != 0)
{
    if (m > maxim)
    {
        next_maxim = maxim;
        maxim = m;
    }
    else if (m > next_maxim)
    {
        next_maxim = m;        
    }
        Console.Write("Введите следующее число: ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
}
Console.WriteLine($"Второе максимальное число: {next_maxim}");
